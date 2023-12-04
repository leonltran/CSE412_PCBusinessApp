namespace CSE412_PCBusinessApp
{
    partial class frmPart
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
            groupBox1 = new GroupBox();
            lParts = new ListView();
            labPartName = new Label();
            cbPartName = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lParts);
            groupBox1.Location = new Point(12, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 403);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parts";
            // 
            // lParts
            // 
            lParts.Location = new Point(6, 22);
            lParts.Name = "lParts";
            lParts.Size = new Size(764, 375);
            lParts.TabIndex = 2;
            lParts.UseCompatibleStateImageBehavior = false;
            // 
            // labPartName
            // 
            labPartName.AutoSize = true;
            labPartName.Location = new Point(12, 9);
            labPartName.Name = "labPartName";
            labPartName.Size = new Size(55, 15);
            labPartName.TabIndex = 5;
            labPartName.Text = "Part Type";
            // 
            // cbPartName
            // 
            cbPartName.FormattingEnabled = true;
            cbPartName.Items.AddRange(new object[] { "CPU", "GPU", "HDD", "RAM", "SSD", "USB" });
            cbPartName.Location = new Point(81, 6);
            cbPartName.Name = "cbPartName";
            cbPartName.Size = new Size(695, 23);
            cbPartName.TabIndex = 4;
            // 
            // frmPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labPartName);
            Controls.Add(cbPartName);
            Controls.Add(groupBox1);
            Name = "frmPart";
            Text = "frmPart";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView lParts;
        private Label labPartName;
        private ComboBox cbPartName;
    }
}