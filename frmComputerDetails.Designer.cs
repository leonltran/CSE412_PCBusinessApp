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
            gbSearch.Location = new Point(12, 12);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(776, 48);
            gbSearch.TabIndex = 4;
            gbSearch.TabStop = false;
            gbSearch.Text = "Computer Search";
            // 
            // lblCompId
            // 
            lblCompId.AutoSize = true;
            lblCompId.Location = new Point(6, 23);
            lblCompId.Name = "lblCompId";
            lblCompId.Size = new Size(75, 15);
            lblCompId.TabIndex = 2;
            lblCompId.Text = "Computer ID";
            // 
            // cbCompID
            // 
            cbCompID.FormattingEnabled = true;
            cbCompID.Location = new Point(106, 19);
            cbCompID.Name = "cbCompID";
            cbCompID.Size = new Size(245, 23);
            cbCompID.TabIndex = 1;
            cbCompID.KeyPress += cbCompID_KeyPress;
            // 
            // gbCompInfo
            // 
            gbCompInfo.Controls.Add(gbCompParts);
            gbCompInfo.Controls.Add(lCompDetails);
            gbCompInfo.Location = new Point(12, 66);
            gbCompInfo.Name = "gbCompInfo";
            gbCompInfo.Size = new Size(776, 372);
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
            gbCompParts.Location = new Point(354, 22);
            gbCompParts.Name = "gbCompParts";
            gbCompParts.Size = new Size(376, 322);
            gbCompParts.TabIndex = 2;
            gbCompParts.TabStop = false;
            gbCompParts.Text = "Computer Part Details";
            // 
            // lbUsb
            // 
            lbUsb.AutoSize = true;
            lbUsb.Location = new Point(22, 264);
            lbUsb.Name = "lbUsb";
            lbUsb.Size = new Size(31, 15);
            lbUsb.TabIndex = 5;
            lbUsb.Text = "USB:";
            // 
            // lbSsd
            // 
            lbSsd.AutoSize = true;
            lbSsd.Location = new Point(22, 213);
            lbSsd.Name = "lbSsd";
            lbSsd.Size = new Size(30, 15);
            lbSsd.TabIndex = 4;
            lbSsd.Text = "SSD:";
            // 
            // lbRam
            // 
            lbRam.AutoSize = true;
            lbRam.Location = new Point(22, 166);
            lbRam.Name = "lbRam";
            lbRam.Size = new Size(36, 15);
            lbRam.TabIndex = 3;
            lbRam.Text = "RAM:";
            // 
            // lbHdd
            // 
            lbHdd.AutoSize = true;
            lbHdd.Location = new Point(22, 122);
            lbHdd.Name = "lbHdd";
            lbHdd.Size = new Size(35, 15);
            lbHdd.TabIndex = 2;
            lbHdd.Text = "HDD:";
            // 
            // lbGpu
            // 
            lbGpu.AutoSize = true;
            lbGpu.Location = new Point(22, 80);
            lbGpu.Name = "lbGpu";
            lbGpu.Size = new Size(33, 15);
            lbGpu.TabIndex = 1;
            lbGpu.Text = "GPU:";
            // 
            // lbCpu
            // 
            lbCpu.AutoSize = true;
            lbCpu.Location = new Point(22, 40);
            lbCpu.Name = "lbCpu";
            lbCpu.Size = new Size(33, 15);
            lbCpu.TabIndex = 0;
            lbCpu.Text = "CPU:";
            // 
            // lCompDetails
            // 
            lCompDetails.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lCompDetails.FullRowSelect = true;
            lCompDetails.Location = new Point(6, 22);
            lCompDetails.Name = "lCompDetails";
            lCompDetails.Size = new Size(312, 336);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbSearch);
            Controls.Add(gbCompInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
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