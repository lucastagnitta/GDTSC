namespace GDTSC {
	partial class Main {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.g = new System.Windows.Forms.DataGridView();
			this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CParent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.todate = new System.Windows.Forms.DateTimePicker();
			this.fromdate = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.maxsize = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.minsize = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.filetitle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.stat = new System.Windows.Forms.ToolStripStatusLabel();
			this.l2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.l3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.l1 = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.g)).BeginInit();
			this.panel1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// g
			// 
			this.g.AllowUserToOrderColumns = true;
			this.g.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.g.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.g.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CName,
            this.CModified,
            this.CSize,
            this.CParent,
            this.CId});
			this.g.Dock = System.Windows.Forms.DockStyle.Fill;
			this.g.Location = new System.Drawing.Point(0, 84);
			this.g.Name = "g";
			this.g.RowHeadersVisible = false;
			this.g.Size = new System.Drawing.Size(1004, 518);
			this.g.TabIndex = 3;
			// 
			// CName
			// 
			this.CName.DataPropertyName = "Name";
			this.CName.HeaderText = "Name";
			this.CName.Name = "CName";
			this.CName.Width = 59;
			// 
			// CModified
			// 
			this.CModified.DataPropertyName = "Modified";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle1.Format = "G";
			dataGridViewCellStyle1.NullValue = null;
			this.CModified.DefaultCellStyle = dataGridViewCellStyle1;
			this.CModified.HeaderText = "Modified";
			this.CModified.Name = "CModified";
			this.CModified.Width = 72;
			// 
			// CSize
			// 
			this.CSize.DataPropertyName = "Size";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "N2";
			dataGridViewCellStyle2.NullValue = null;
			this.CSize.DefaultCellStyle = dataGridViewCellStyle2;
			this.CSize.HeaderText = "Size KB";
			this.CSize.Name = "CSize";
			this.CSize.Width = 66;
			// 
			// CParent
			// 
			this.CParent.DataPropertyName = "Parent";
			this.CParent.HeaderText = "Original path before trashing";
			this.CParent.Name = "CParent";
			this.CParent.Width = 170;
			// 
			// CId
			// 
			this.CId.DataPropertyName = "Id";
			this.CId.HeaderText = "Id";
			this.CId.Name = "CId";
			this.CId.Width = 42;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.todate);
			this.panel1.Controls.Add(this.fromdate);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.maxsize);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.minsize);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.filetitle);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1004, 84);
			this.panel1.TabIndex = 4;
			// 
			// todate
			// 
			this.todate.Location = new System.Drawing.Point(116, 32);
			this.todate.Name = "todate";
			this.todate.Size = new System.Drawing.Size(200, 21);
			this.todate.TabIndex = 18;
			// 
			// fromdate
			// 
			this.fromdate.Location = new System.Drawing.Point(116, 8);
			this.fromdate.Name = "fromdate";
			this.fromdate.Size = new System.Drawing.Size(200, 21);
			this.fromdate.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.Control;
			this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(68, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 13);
			this.label5.TabIndex = 17;
			this.label5.Text = "to date";
			// 
			// maxsize
			// 
			this.maxsize.Items.AddRange(new object[] {
            "0",
            "0.01",
            "0.05",
            "0.1",
            "0.5",
            "1",
            "5",
            "10",
            "50",
            "100",
            "500",
            "1000",
            "5000",
            "10000",
            "50000",
            "100000"});
			this.maxsize.Location = new System.Drawing.Point(408, 32);
			this.maxsize.Name = "maxsize";
			this.maxsize.Size = new System.Drawing.Size(59, 21);
			this.maxsize.TabIndex = 16;
			this.maxsize.Text = "100000";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.Control;
			this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(332, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "max size (MB)";
			// 
			// minsize
			// 
			this.minsize.Items.AddRange(new object[] {
            "0",
            "0.01",
            "0.05",
            "0.1",
            "0.5",
            "1",
            "5",
            "10",
            "50",
            "100",
            "500",
            "1000",
            "5000",
            "10000",
            "50000",
            "100000"});
			this.minsize.Location = new System.Drawing.Point(408, 8);
			this.minsize.Name = "minsize";
			this.minsize.Size = new System.Drawing.Size(59, 21);
			this.minsize.TabIndex = 16;
			this.minsize.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(336, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 13);
			this.label3.TabIndex = 15;
			this.label3.Text = "min size (MB)";
			// 
			// filetitle
			// 
			this.filetitle.Location = new System.Drawing.Point(116, 56);
			this.filetitle.Name = "filetitle";
			this.filetitle.Size = new System.Drawing.Size(200, 21);
			this.filetitle.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(18, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "file name contains";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(56, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "from date";
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(476, 30);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "Remove from Trash";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(476, 7);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Search";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stat,
            this.l1,
            this.l2,
            this.l3});
			this.statusStrip1.Location = new System.Drawing.Point(0, 602);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1004, 22);
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// stat
			// 
			this.stat.AutoSize = false;
			this.stat.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.stat.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.stat.Name = "stat";
			this.stat.Size = new System.Drawing.Size(118, 17);
			// 
			// l2
			// 
			this.l2.AutoSize = false;
			this.l2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.l2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.l2.Name = "l2";
			this.l2.Size = new System.Drawing.Size(118, 17);
			// 
			// l3
			// 
			this.l3.AutoSize = false;
			this.l3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.l3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.l3.Name = "l3";
			this.l3.Size = new System.Drawing.Size(118, 17);
			// 
			// l1
			// 
			this.l1.AutoSize = false;
			this.l1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.l1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.l1.Name = "l1";
			this.l1.Size = new System.Drawing.Size(118, 17);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1004, 624);
			this.Controls.Add(this.g);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Google Drive Trash Selective Cleaner";
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.g)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView g;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel stat;
		private System.Windows.Forms.ToolStripStatusLabel l1;
		private System.Windows.Forms.ToolStripStatusLabel l2;
		private System.Windows.Forms.ToolStripStatusLabel l3;
		private System.Windows.Forms.ComboBox maxsize;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox minsize;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox filetitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker todate;
		private System.Windows.Forms.DateTimePicker fromdate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridViewTextBoxColumn CName;
		private System.Windows.Forms.DataGridViewTextBoxColumn CModified;
		private System.Windows.Forms.DataGridViewTextBoxColumn CSize;
		private System.Windows.Forms.DataGridViewTextBoxColumn CParent;
		private System.Windows.Forms.DataGridViewTextBoxColumn CId;
	}
}

