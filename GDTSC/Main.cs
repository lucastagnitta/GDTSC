using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Data;
using System.Xml;
using System.Globalization;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v2;
using Google.Apis.Drive.v2.Data;
using Google.Apis.Services;

namespace GDTSC {
	public partial class Main:Form {
		class CacheEntry {
			public string title {get; private set;}
			public string parentid {get; private set;}

			public CacheEntry(string title, string parentid) {
				this.title = title;
				this.parentid = parentid;
			}
		};

		Dictionary<string, CacheEntry> folderscache = new Dictionary<string, CacheEntry>();
		CultureInfo culture = new CultureInfo("en-US");
		DriveService service;
		DataTable table; 

		public Main() {
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e) {
			fromdate.Value = new DateTime(1900, 1, 1);
			todate.Value = DateTime.Today.Date.AddDays(-30);
		}

		// recurse up the "folder hierarchy"
		// as is known Google Drive folders structure is pretty loose about hierarchy, everything is done 
		// with pointers and labels, for example: a file may have more than one parent
		// anyway, for simplicity I'll treat it like an ordinary file system structure, picking the 
		// first parent of a file/folder
		private string GetFullPath(string id) {
			CacheEntry folder;

			if (id == "")
				return "";
			if (folderscache.ContainsKey(id))
				folder = folderscache[id];
			else {
				// get metadata of the folder
				FilesResource.GetRequest request = service.Files.Get(id);
				request.Fields = "title,parents/id";
				File file = request.Execute();
				if (file.Parents.Count > 0)
					folder = new CacheEntry(file.Title, file.Parents[0].Id);
				else
					// no parents
					folder = new CacheEntry(file.Title, "");
				folderscache.Add(id, folder);
			}
			return GetFullPath(folder.parentid) + "/" + folder.title;
		}

		private void button1_Click_1(object sender, EventArgs e) {
			System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;

			table = new DataTable();
			g.AutoGenerateColumns = false;
			//g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
			table.Columns.Add("Name", typeof(string));
			table.Columns.Add("Modified", typeof(DateTime));
			table.Columns.Add("Size", typeof(double));
			table.Columns.Add("Parent", typeof(string));
			table.Columns.Add("Id", typeof(string));
			g.DataSource = table;

			stat.Text = "Connecting";

			System.IO.FileStream stream = new System.IO.FileStream(
				"client_secret.json",
				System.IO.FileMode.Open, 
				System.IO.FileAccess.Read
			);

			// credential.Token
			// https://developers.google.com/accounts/docs/OAuth2InstalledApp			
			// http://stackoverflow.com/questions/7367449/google-api-how-to-authenticate-without-redirection
			// http://stackoverflow.com/questions/9809742/how-to-automate-login-to-google-api-to-get-oauth-2-0-token-to-access-known-user
			// token is stored here: %AppData%\Roaming\Drive.Auth.Store\Google.Apis.Auth.OAuth2.Responses.TokenResponse-user
			// http://www.daimto.com/google-oauth2-csharp/#Loading_Stored_refresh-Token
			UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.Load(stream).Secrets, 
                new[] {DriveService.Scope.Drive},
                "user",
                CancellationToken.None
			).Result;
			stream.Close();

            // Create the service.
            service = new DriveService(
				new BaseClientService.Initializer() {
					HttpClientInitializer = credential,
					ApplicationName = "Google Drive Trash Selective Cleaner",
				}
			);

			// first request
			FilesResource.ListRequest request = service.Files.List();
			request.MaxResults = 1000;
			request.Fields = "items(id,fileSize,labels/trashed,modifiedDate,title,parents/id),nextPageToken";
			// RFC 3339 format, default timezone is UTC, e.g., 2012-06-04T12:00:00-08:00.
			string d1 = XmlConvert.ToString(fromdate.Value, XmlDateTimeSerializationMode.Utc);
			string d2 = XmlConvert.ToString(todate.Value, XmlDateTimeSerializationMode.Utc);

			string fname;
			string fext;
			int ind = filetitle.Text.LastIndexOf('.');
			if (ind >= 0) { 
				fname = filetitle.Text.Substring(0, ind);
				fext = filetitle.Text.Substring(ind);
			} else {
				fname = filetitle.Text;
				fext = "";
			}
			request.Q = 
				"trashed=true " +
				"and modifiedDate >= '" + d1 + "' " +
				"and modifiedDate <= '" + d2 + "' " +
				"and title contains '" + fname + "' ";

			double savedmb = 0;
			int count = 0;
			long fromsize = (long)(double.Parse(minsize.Text, culture.NumberFormat) * 1024 * 1024);
			long tosize = (long)(double.Parse(maxsize.Text, culture.NumberFormat) * 1024 * 1024);
			stat.Text = "Searching";
			do {
				FileList files = request.Execute();
				request.PageToken = files.NextPageToken;
				foreach(File f in files.Items) {
					// since filesize and fileextension are not queryable
					// (and mimeType is not reliable)
					long filesize = f.FileSize ?? 0;
					if (filesize >= fromsize && filesize <= tosize && f.Title.EndsWith(fext)) {
						DataRow r = table.NewRow();
						r["Id"] = f.Id;
						r["Name"] = f.Title;
						r["Modified"] = f.ModifiedDate;
						double kb = (double)(filesize) / 1024;
						savedmb += kb / 1024;
						r["Size"] = kb;
						// filling the first rows will be slower because of an empty cache 
						if (f.Parents.Count > 0) 
							r["Parent"] = GetFullPath(f.Parents[0].Id);
						table.Rows.Add(r);
						count++;
						l1.Text = "Items: " + count;
						l2.Text = "MB: " + Math.Round(savedmb, 2);
						Application.DoEvents();
					}
				}

			} while (!String.IsNullOrEmpty(request.PageToken));			

			System.Windows.Forms.Cursor.Current = Cursors.Default;
			button2.Enabled = count > 0;
			stat.Text = "";
			MessageBox.Show("Done searching"); 
		}

		private void button2_Click(object sender, EventArgs e) {
			if (
				MessageBox.Show(
					"Confirm deleting of shown files from trash?", 
					"", 
					MessageBoxButtons.YesNo
				)
				!= DialogResult.Yes
			)
				return;

			stat.Text = "Deleting";
			int c = 0;
			foreach(DataRow r in table.Rows) {
				c++;
				l3.Text = c + "/" + table.Rows.Count;
				Application.DoEvents();

				/*
				// the paranoid's check, tested OK with about 10000 files
				FilesResource.GetRequest prequest = service.Files.Get(r["id"].ToString());
				prequest.Fields = "labels/trashed";
				File file = prequest.Execute();
				if (!(bool) file.Labels.Trashed)
					MessageBox.Show("Not Trashed!"); 
				*/

				FilesResource.DeleteRequest request = service.Files.Delete(r["id"].ToString());

				// sometime happens that google server replays with errors like 
				// 500 - Internal server error
				// I'm assuming this is transient and recoverable, so retrying 4 more times before giving up
				// going beyond that probably means a service outage and google drive wouldn't work anyway
				for(int i = 0; i < 5; i++) {
					try {
						request.Execute();
						break;
					} catch (Exception ex) {
						if (i==4)
							throw(ex);
						Thread.Sleep(1000);
					}
				}
			}
			table.Rows.Clear();
			stat.Text = "";
			button2.Enabled = false;
			MessageBox.Show("Done deleting");
		}
	}
}
