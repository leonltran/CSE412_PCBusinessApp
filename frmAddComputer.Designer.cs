namespace CSE412_PCBusinessApp
{
    partial class frmAddComputer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddComputer));
            cbUSB = new ComboBox();
            cbSSD = new ComboBox();
            cbRAM = new ComboBox();
            cbHDD = new ComboBox();
            cbGPU = new ComboBox();
            lblUSB = new Label();
            cbCPU = new ComboBox();
            btnAdd = new Button();
            lblSSD = new Label();
            lblGPU = new Label();
            lblRAM = new Label();
            lblHDD = new Label();
            lblCPU = new Label();
            SuspendLayout();
            // 
            // cbUSB
            // 
            cbUSB.FormattingEnabled = true;
            cbUSB.Location = new Point(12, 255);
            cbUSB.Name = "cbUSB";
            cbUSB.Size = new Size(376, 23);
            cbUSB.TabIndex = 28;
            // 
            // cbSSD
            // 
            cbSSD.FormattingEnabled = true;
            cbSSD.Location = new Point(12, 203);
            cbSSD.Name = "cbSSD";
            cbSSD.Size = new Size(376, 23);
            cbSSD.TabIndex = 27;
            // 
            // cbRAM
            // 
            cbRAM.FormattingEnabled = true;
            cbRAM.Location = new Point(12, 159);
            cbRAM.Name = "cbRAM";
            cbRAM.Size = new Size(376, 23);
            cbRAM.TabIndex = 26;
            // 
            // cbHDD
            // 
            cbHDD.FormattingEnabled = true;
            cbHDD.Location = new Point(12, 115);
            cbHDD.Name = "cbHDD";
            cbHDD.Size = new Size(376, 23);
            cbHDD.TabIndex = 25;
            // 
            // cbGPU
            // 
            cbGPU.FormattingEnabled = true;
            cbGPU.Location = new Point(12, 71);
            cbGPU.Name = "cbGPU";
            cbGPU.Size = new Size(376, 23);
            cbGPU.TabIndex = 24;
            // 
            // lblUSB
            // 
            lblUSB.AutoSize = true;
            lblUSB.Location = new Point(12, 237);
            lblUSB.Name = "lblUSB";
            lblUSB.Size = new Size(28, 15);
            lblUSB.TabIndex = 23;
            lblUSB.Text = "USB";
            // 
            // cbCPU
            // 
            cbCPU.FormattingEnabled = true;
            cbCPU.Location = new Point(12, 27);
            cbCPU.Name = "cbCPU";
            cbCPU.Size = new Size(376, 23);
            cbCPU.TabIndex = 22;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(235, 306);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(153, 42);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add New Computer";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblSSD
            // 
            lblSSD.AutoSize = true;
            lblSSD.Location = new Point(12, 185);
            lblSSD.Name = "lblSSD";
            lblSSD.Size = new Size(27, 15);
            lblSSD.TabIndex = 21;
            lblSSD.Text = "SSD";
            // 
            // lblGPU
            // 
            lblGPU.AutoSize = true;
            lblGPU.Location = new Point(12, 53);
            lblGPU.Name = "lblGPU";
            lblGPU.Size = new Size(30, 15);
            lblGPU.TabIndex = 20;
            lblGPU.Text = "GPU";
            // 
            // lblRAM
            // 
            lblRAM.AutoSize = true;
            lblRAM.Location = new Point(12, 141);
            lblRAM.Name = "lblRAM";
            lblRAM.Size = new Size(33, 15);
            lblRAM.TabIndex = 18;
            lblRAM.Text = "RAM";
            // 
            // lblHDD
            // 
            lblHDD.AutoSize = true;
            lblHDD.Location = new Point(12, 97);
            lblHDD.Name = "lblHDD";
            lblHDD.Size = new Size(32, 15);
            lblHDD.TabIndex = 17;
            lblHDD.Text = "HDD";
            // 
            // lblCPU
            // 
            lblCPU.AutoSize = true;
            lblCPU.Location = new Point(12, 9);
            lblCPU.Name = "lblCPU";
            lblCPU.Size = new Size(30, 15);
            lblCPU.TabIndex = 16;
            lblCPU.Text = "CPU";
            // 
            // frmAddComputer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 358);
            Controls.Add(cbUSB);
            Controls.Add(cbSSD);
            Controls.Add(cbRAM);
            Controls.Add(cbHDD);
            Controls.Add(cbGPU);
            Controls.Add(lblUSB);
            Controls.Add(cbCPU);
            Controls.Add(btnAdd);
            Controls.Add(lblSSD);
            Controls.Add(lblGPU);
            Controls.Add(lblRAM);
            Controls.Add(lblHDD);
            Controls.Add(lblCPU);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAddComputer";
            Text = "Add New Computer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbUSB;
        private ComboBox cbSSD;
        private ComboBox cbRAM;
        private ComboBox cbHDD;
        private ComboBox cbGPU;
        private Label lblUSB;
        private ComboBox cbCPU;
        private Button btnAdd;
        private Label lblSSD;
        private Label lblGPU;
        private Label lblRAM;
        private Label lblHDD;
        private Label lblCPU;
    }
}