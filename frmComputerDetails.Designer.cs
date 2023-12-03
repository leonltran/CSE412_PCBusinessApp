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
            gbSearch = new GroupBox();
            lblCompId = new Label();
            cbCompID = new ComboBox();
            gbCompInfo = new GroupBox();
            gbSearch.SuspendLayout();
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
            // 
            // gbCompInfo
            // 
            gbCompInfo.Location = new Point(12, 66);
            gbCompInfo.Name = "gbCompInfo";
            gbCompInfo.Size = new Size(776, 372);
            gbCompInfo.TabIndex = 5;
            gbCompInfo.TabStop = false;
            gbCompInfo.Text = "Computer Information";
            // 
            // frmComputerDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbSearch);
            Controls.Add(gbCompInfo);
            Name = "frmComputerDetails";
            Text = "frmComputerDetails";
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbSearch;
        private Label lblCompId;
        private ComboBox cbCompID;
        private GroupBox gbCompInfo;
    }
}