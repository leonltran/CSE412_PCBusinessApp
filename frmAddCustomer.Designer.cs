namespace CSE412_PCBusinessApp
{
    partial class frmAddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCustomer));
            lblName = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblComment = new Label();
            btnAdd = new Button();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtComment = new TextBox();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(97, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name (Required)";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(12, 97);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address";
            lblAddress.Click += lblAddress_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(12, 141);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(88, 15);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone Number";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 53);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(139, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email Address (Required)";
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.Location = new Point(12, 185);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(61, 15);
            lblComment.TabIndex = 8;
            lblComment.Text = "Comment";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(235, 396);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(153, 42);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add New Customer";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 159);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(376, 23);
            txtPhone.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(12, 115);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(376, 23);
            txtAddress.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 71);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(376, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtComment
            // 
            txtComment.Location = new Point(12, 203);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(376, 187);
            txtComment.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(376, 23);
            txtName.TabIndex = 0;
            // 
            // frmAddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 450);
            Controls.Add(btnAdd);
            Controls.Add(txtComment);
            Controls.Add(lblComment);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAddCustomer";
            Text = "Add New Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblAddress;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblComment;
        private Button btnAdd;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtComment;
        private TextBox txtName;
    }
}