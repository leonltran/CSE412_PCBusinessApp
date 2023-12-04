namespace CSE412_PCBusinessApp
{
    partial class frmAddOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOrder));
            btnAdd = new Button();
            lblPrice = new Label();
            lblType = new Label();
            lblDate = new Label();
            lblCustomer = new Label();
            gbComputer = new GroupBox();
            cbUSB = new ComboBox();
            cbSSD = new ComboBox();
            cbRAM = new ComboBox();
            cbHDD = new ComboBox();
            cbGPU = new ComboBox();
            lblUSB = new Label();
            cbCPU = new ComboBox();
            lblSSD = new Label();
            lblGPU = new Label();
            lblRAM = new Label();
            lblHDD = new Label();
            lblCPU = new Label();
            cbCustomer = new ComboBox();
            dtpDate = new DateTimePicker();
            cbType = new ComboBox();
            txtPrice = new TextBox();
            gbComputer.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(235, 396);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(153, 42);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add New Order";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 53);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 18;
            lblPrice.Text = "Price";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(12, 141);
            lblType.Name = "lblType";
            lblType.Size = new Size(31, 15);
            lblType.TabIndex = 16;
            lblType.Text = "Type";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(12, 97);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 15);
            lblDate.TabIndex = 13;
            lblDate.Text = "Date";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(12, 9);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(59, 15);
            lblCustomer.TabIndex = 10;
            lblCustomer.Text = "Customer";
            // 
            // gbComputer
            // 
            gbComputer.Controls.Add(cbUSB);
            gbComputer.Controls.Add(cbSSD);
            gbComputer.Controls.Add(cbRAM);
            gbComputer.Controls.Add(cbHDD);
            gbComputer.Controls.Add(cbGPU);
            gbComputer.Controls.Add(lblUSB);
            gbComputer.Controls.Add(cbCPU);
            gbComputer.Controls.Add(lblSSD);
            gbComputer.Controls.Add(lblGPU);
            gbComputer.Controls.Add(lblRAM);
            gbComputer.Controls.Add(lblHDD);
            gbComputer.Controls.Add(lblCPU);
            gbComputer.Location = new Point(12, 188);
            gbComputer.Name = "gbComputer";
            gbComputer.Size = new Size(376, 202);
            gbComputer.TabIndex = 20;
            gbComputer.TabStop = false;
            gbComputer.Text = "Computer";
            // 
            // cbUSB
            // 
            cbUSB.FormattingEnabled = true;
            cbUSB.Location = new Point(46, 167);
            cbUSB.Name = "cbUSB";
            cbUSB.Size = new Size(324, 23);
            cbUSB.TabIndex = 40;
            // 
            // cbSSD
            // 
            cbSSD.FormattingEnabled = true;
            cbSSD.Location = new Point(46, 138);
            cbSSD.Name = "cbSSD";
            cbSSD.Size = new Size(324, 23);
            cbSSD.TabIndex = 39;
            // 
            // cbRAM
            // 
            cbRAM.FormattingEnabled = true;
            cbRAM.Location = new Point(46, 110);
            cbRAM.Name = "cbRAM";
            cbRAM.Size = new Size(324, 23);
            cbRAM.TabIndex = 38;
            // 
            // cbHDD
            // 
            cbHDD.FormattingEnabled = true;
            cbHDD.Location = new Point(46, 80);
            cbHDD.Name = "cbHDD";
            cbHDD.Size = new Size(324, 23);
            cbHDD.TabIndex = 37;
            // 
            // cbGPU
            // 
            cbGPU.FormattingEnabled = true;
            cbGPU.Location = new Point(46, 51);
            cbGPU.Name = "cbGPU";
            cbGPU.Size = new Size(324, 23);
            cbGPU.TabIndex = 36;
            // 
            // lblUSB
            // 
            lblUSB.AutoSize = true;
            lblUSB.Location = new Point(15, 170);
            lblUSB.Name = "lblUSB";
            lblUSB.Size = new Size(28, 15);
            lblUSB.TabIndex = 35;
            lblUSB.Text = "USB";
            // 
            // cbCPU
            // 
            cbCPU.FormattingEnabled = true;
            cbCPU.Location = new Point(46, 22);
            cbCPU.Name = "cbCPU";
            cbCPU.Size = new Size(324, 23);
            cbCPU.TabIndex = 34;
            // 
            // lblSSD
            // 
            lblSSD.AutoSize = true;
            lblSSD.Location = new Point(16, 141);
            lblSSD.Name = "lblSSD";
            lblSSD.Size = new Size(27, 15);
            lblSSD.TabIndex = 33;
            lblSSD.Text = "SSD";
            // 
            // lblGPU
            // 
            lblGPU.AutoSize = true;
            lblGPU.Location = new Point(13, 54);
            lblGPU.Name = "lblGPU";
            lblGPU.Size = new Size(30, 15);
            lblGPU.TabIndex = 32;
            lblGPU.Text = "GPU";
            // 
            // lblRAM
            // 
            lblRAM.AutoSize = true;
            lblRAM.Location = new Point(10, 113);
            lblRAM.Name = "lblRAM";
            lblRAM.Size = new Size(33, 15);
            lblRAM.TabIndex = 31;
            lblRAM.Text = "RAM";
            // 
            // lblHDD
            // 
            lblHDD.AutoSize = true;
            lblHDD.Location = new Point(11, 83);
            lblHDD.Name = "lblHDD";
            lblHDD.Size = new Size(32, 15);
            lblHDD.TabIndex = 30;
            lblHDD.Text = "HDD";
            // 
            // lblCPU
            // 
            lblCPU.AutoSize = true;
            lblCPU.Location = new Point(13, 25);
            lblCPU.Name = "lblCPU";
            lblCPU.Size = new Size(30, 15);
            lblCPU.TabIndex = 29;
            lblCPU.Text = "CPU";
            // 
            // cbCustomer
            // 
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(12, 27);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(376, 23);
            cbCustomer.TabIndex = 21;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(12, 115);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(376, 23);
            dtpDate.TabIndex = 22;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Standard", "Express" });
            cbType.Location = new Point(12, 159);
            cbType.Name = "cbType";
            cbType.Size = new Size(376, 23);
            cbType.TabIndex = 23;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(12, 71);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(376, 23);
            txtPrice.TabIndex = 24;
            // 
            // frmAddOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 450);
            Controls.Add(txtPrice);
            Controls.Add(cbType);
            Controls.Add(dtpDate);
            Controls.Add(cbCustomer);
            Controls.Add(gbComputer);
            Controls.Add(btnAdd);
            Controls.Add(lblPrice);
            Controls.Add(lblType);
            Controls.Add(lblDate);
            Controls.Add(lblCustomer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAddOrder";
            Text = "Add New Order";
            gbComputer.ResumeLayout(false);
            gbComputer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtComment;
        private Label lblComputer;
        private TextBox txtEmail;
        private Label lblPrice;
        private Label lblType;
        private TextBox txtAddress;
        private Label lblDate;
        private TextBox txtName;
        private Label lblCustomer;
        private GroupBox gbComputer;
        private ComboBox cbCustomer;
        private DateTimePicker dtpDate;
        private ComboBox cbType;
        private ComboBox cbUSB;
        private ComboBox cbSSD;
        private ComboBox cbRAM;
        private ComboBox cbHDD;
        private ComboBox cbGPU;
        private Label lblUSB;
        private ComboBox cbCPU;
        private Label lblSSD;
        private Label lblGPU;
        private Label lblRAM;
        private Label lblHDD;
        private Label lblCPU;
        private TextBox txtPrice;
    }
}