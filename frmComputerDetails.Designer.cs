namespace CSE412_PCBusinessApp
{
    partial class frmComputerDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComputerDetails));
            gbSearch = new GroupBox();
            lblCompId = new Label();
            cbCompID = new ComboBox();
            gbCompInfo = new GroupBox();
            gbCompParts = new GroupBox();
            lbUsb = new Label();
            lbSsd = new Label();
            lbRam = new Label();
            lbHdd = new Label();
            lbGpu = new Label();
            lbCpu = new Label();
            lCompDetails = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            gbSearch.SuspendLayout();
            gbCompInfo.SuspendLayout();
            gbCompParts.SuspendLayout();
            SuspendLayout();
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(lblCompId);
            gbSearch.Controls.Add(cbCompID);
            gbSearch.Location = new Point(22, 26);
            gbSearch.Margin = new Padding(6, 6, 6, 6);
            gbSearch.Name = "gbSearch";
            gbSearch.Padding = new Padding(6, 6, 6, 6);
            gbSearch.Size = new Size(1441, 102);
            gbSearch.TabIndex = 4;
            gbSearch.TabStop = false;
            gbSearch.Text = "Computer Search";
            // 
            // lblCompId
            // 
            lblCompId.AutoSize = true;
            lblCompId.Location = new Point(11, 49);
            lblCompId.Margin = new Padding(6, 0, 6, 0);
            lblCompId.Name = "lblCompId";
            lblCompId.Size = new Size(151, 32);
            lblCompId.TabIndex = 2;
            lblCompId.Text = "Computer ID";
            // 
            // cbCompID
            // 
            cbCompID.FormattingEnabled = true;
            cbCompID.Location = new Point(197, 41);
            cbCompID.Margin = new Padding(6, 6, 6, 6);
            cbCompID.Name = "cbCompID";
            cbCompID.Size = new Size(452, 40);
            cbCompID.TabIndex = 1;
            cbCompID.KeyPress += cbCompID_KeyPress;
            // 
            // gbCompInfo
            // 
            gbCompInfo.Controls.Add(gbCompParts);
            gbCompInfo.Controls.Add(lCompDetails);
            gbCompInfo.Location = new Point(22, 141);
            gbCompInfo.Margin = new Padding(6, 6, 6, 6);
            gbCompInfo.Name = "gbCompInfo";
            gbCompInfo.Padding = new Padding(6, 6, 6, 6);
            gbCompInfo.Size = new Size(1441, 794);
            gbCompInfo.TabIndex = 5;
            gbCompInfo.TabStop = false;
            gbCompInfo.Text = "Computer Information";
            // 
            // gbCompParts
            // 
            gbCompParts.Controls.Add(lbUsb);
            gbCompParts.Controls.Add(lbSsd);
            gbCompParts.Controls.Add(lbRam);
            gbCompParts.Controls.Add(lbHdd);
            gbCompParts.Controls.Add(lbGpu);
            gbCompParts.Controls.Add(lbCpu);
            gbCompParts.Location = new Point(657, 47);
            gbCompParts.Margin = new Padding(6, 6, 6, 6);
            gbCompParts.Name = "gbCompParts";
            gbCompParts.Padding = new Padding(6, 6, 6, 6);
            gbCompParts.Size = new Size(698, 687);
            gbCompParts.TabIndex = 2;
            gbCompParts.TabStop = false;
            gbCompParts.Text = "Computer Part Details";
            // 
            // lbUsb
            // 
            lbUsb.AutoSize = true;
            lbUsb.Location = new Point(41, 563);
            lbUsb.Margin = new Padding(6, 0, 6, 0);
            lbUsb.Name = "lbUsb";
            lbUsb.Size = new Size(62, 32);
            lbUsb.TabIndex = 5;
            lbUsb.Text = "USB:";
            // 
            // lbSsd
            // 
            lbSsd.AutoSize = true;
            lbSsd.Location = new Point(41, 454);
            lbSsd.Margin = new Padding(6, 0, 6, 0);
            lbSsd.Name = "lbSsd";
            lbSsd.Size = new Size(62, 32);
            lbSsd.TabIndex = 4;
            lbSsd.Text = "SSD:";
            // 
            // lbRam
            // 
            lbRam.AutoSize = true;
            lbRam.Location = new Point(41, 354);
            lbRam.Margin = new Padding(6, 0, 6, 0);
            lbRam.Name = "lbRam";
            lbRam.Size = new Size(70, 32);
            lbRam.TabIndex = 3;
            lbRam.Text = "RAM:";
            // 
            // lbHdd
            // 
            lbHdd.AutoSize = true;
            lbHdd.Location = new Point(41, 260);
            lbHdd.Margin = new Padding(6, 0, 6, 0);
            lbHdd.Name = "lbHdd";
            lbHdd.Size = new Size(70, 32);
            lbHdd.TabIndex = 2;
            lbHdd.Text = "HDD:";
            // 
            // lbGpu
            // 
            lbGpu.AutoSize = true;
            lbGpu.Location = new Point(41, 171);
            lbGpu.Margin = new Padding(6, 0, 6, 0);
            lbGpu.Name = "lbGpu";
            lbGpu.Size = new Size(64, 32);
            lbGpu.TabIndex = 1;
            lbGpu.Text = "GPU:";
            // 
            // lbCpu
            // 
            lbCpu.AutoSize = true;
            lbCpu.Location = new Point(41, 85);
            lbCpu.Margin = new Padding(6, 0, 6, 0);
            lbCpu.Name = "lbCpu";
            lbCpu.Size = new Size(63, 32);
            lbCpu.TabIndex = 0;
            lbCpu.Text = "CPU:";
            // 
            // lCompDetails
            // 
            lCompDetails.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lCompDetails.FullRowSelect = true;
            lCompDetails.Location = new Point(11, 47);
            lCompDetails.Margin = new Padding(6, 6, 6, 6);
            lCompDetails.Name = "lCompDetails";
            lCompDetails.Size = new Size(576, 712);
            lCompDetails.TabIndex = 1;
            lCompDetails.UseCompatibleStateImageBehavior = false;
            lCompDetails.View = View.Details;
            lCompDetails.SelectedIndexChanged += lCompDetails_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Computer ID";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Type";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Weight";
            columnHeader3.Width = 90;
            // 
            // frmComputerDetails
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(gbSearch);
            Controls.Add(gbCompInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 6, 6, 6);
            Name = "frmComputerDetails";
            Text = "Computer Details";
            Load += frmComputerDetails_Load;
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            gbCompInfo.ResumeLayout(false);
            gbCompParts.ResumeLayout(false);
            gbCompParts.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbSearch;
        private Label lblCompId;
        private ComboBox cbCompID;
        private GroupBox gbCompInfo;
        private ListView lCompDetails;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private GroupBox gbCompParts;
        private Label lbUsb;
        private Label lbSsd;
        private Label lbRam;
        private Label lbHdd;
        private Label lbGpu;
        private Label lbCpu;
    }
}