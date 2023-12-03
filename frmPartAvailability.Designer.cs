namespace CSE412_PCBusinessApp
{
    partial class frmPartAvailability
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
            gbItemInfo = new GroupBox();
            labPartName = new Label();
            cbPartName = new ComboBox();
            gbQuantities = new GroupBox();
            gbItemInfo.SuspendLayout();
            SuspendLayout();
            // 
            // gbItemInfo
            // 
            gbItemInfo.Controls.Add(labPartName);
            gbItemInfo.Controls.Add(cbPartName);
            gbItemInfo.Location = new Point(12, 12);
            gbItemInfo.Name = "gbItemInfo";
            gbItemInfo.Size = new Size(776, 56);
            gbItemInfo.TabIndex = 1;
            gbItemInfo.TabStop = false;
            gbItemInfo.Text = "Part Search";
            // 
            // labPartName
            // 
            labPartName.AutoSize = true;
            labPartName.Location = new Point(6, 25);
            labPartName.Name = "labPartName";
            labPartName.Size = new Size(63, 15);
            labPartName.TabIndex = 3;
            labPartName.Text = "Part Name";
            // 
            // cbPartName
            // 
            cbPartName.FormattingEnabled = true;
            cbPartName.Location = new Point(75, 22);
            cbPartName.Name = "cbPartName";
            cbPartName.Size = new Size(695, 23);
            cbPartName.TabIndex = 2;
            // 
            // gbQuantities
            // 
            gbQuantities.Location = new Point(12, 74);
            gbQuantities.Name = "gbQuantities";
            gbQuantities.Size = new Size(776, 364);
            gbQuantities.TabIndex = 2;
            gbQuantities.TabStop = false;
            gbQuantities.Text = "Part Stock";
            // 
            // frmPartAvailability
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbQuantities);
            Controls.Add(gbItemInfo);
            Name = "frmPartAvailability";
            Text = "frmPartAvailability";
            gbItemInfo.ResumeLayout(false);
            gbItemInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbItemInfo;
        private Label labPartName;
        private ComboBox cbPartName;
        private GroupBox gbQuantities;
    }
}