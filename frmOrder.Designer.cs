namespace CSE412_PCBusinessApp
{
    partial class frmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            grbActions = new GroupBox();
            btnCustomerDetails = new Button();
            btnComputerDetails = new Button();
            btnChangeStatus = new Button();
            btnOrderNewComputer = new Button();
            grbComputers = new GroupBox();
            lsvComputers = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            grbInfo = new GroupBox();
            lblComment = new Label();
            lblStatus = new Label();
            lblType = new Label();
            lblDate = new Label();
            lblPrice = new Label();
            lblCustomer = new Label();
            lblOrderID = new Label();
            grbActions.SuspendLayout();
            grbComputers.SuspendLayout();
            grbInfo.SuspendLayout();
            SuspendLayout();
            // 
            // grbActions
            // 
            grbActions.Controls.Add(btnCustomerDetails);
            grbActions.Controls.Add(btnComputerDetails);
            grbActions.Controls.Add(btnChangeStatus);
            grbActions.Controls.Add(btnOrderNewComputer);
            grbActions.Location = new Point(12, 12);
            grbActions.Name = "grbActions";
            grbActions.Padding = new Padding(7);
            grbActions.Size = new Size(324, 145);
            grbActions.TabIndex = 4;
            grbActions.TabStop = false;
            grbActions.Text = "Actions";
            // 
            // btnCustomerDetails
            // 
            btnCustomerDetails.Location = new Point(214, 82);
            btnCustomerDetails.Name = "btnCustomerDetails";
            btnCustomerDetails.Size = new Size(100, 50);
            btnCustomerDetails.TabIndex = 4;
            btnCustomerDetails.Text = "View Customer Details...";
            btnCustomerDetails.UseVisualStyleBackColor = true;
            btnCustomerDetails.Click += btnCustomerDetails_Click;
            // 
            // btnComputerDetails
            // 
            btnComputerDetails.Location = new Point(214, 26);
            btnComputerDetails.Name = "btnComputerDetails";
            btnComputerDetails.Size = new Size(100, 50);
            btnComputerDetails.TabIndex = 3;
            btnComputerDetails.Text = "View Computer Details...";
            btnComputerDetails.UseVisualStyleBackColor = true;
            btnComputerDetails.Click += btnComputerDetails_Click;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.Location = new Point(10, 82);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(198, 50);
            btnChangeStatus.TabIndex = 2;
            btnChangeStatus.Text = "Change Order Status...";
            btnChangeStatus.UseVisualStyleBackColor = true;
            btnChangeStatus.Click += btnChangeStatus_Click;
            // 
            // btnOrderNewComputer
            // 
            btnOrderNewComputer.Location = new Point(10, 26);
            btnOrderNewComputer.Name = "btnOrderNewComputer";
            btnOrderNewComputer.Size = new Size(198, 50);
            btnOrderNewComputer.TabIndex = 1;
            btnOrderNewComputer.Text = "Add New Computer...";
            btnOrderNewComputer.UseVisualStyleBackColor = true;
            btnOrderNewComputer.Click += btnOrderNewComputer_Click;
            // 
            // grbComputers
            // 
            grbComputers.Controls.Add(lsvComputers);
            grbComputers.Location = new Point(342, 12);
            grbComputers.Name = "grbComputers";
            grbComputers.Size = new Size(446, 426);
            grbComputers.TabIndex = 5;
            grbComputers.TabStop = false;
            grbComputers.Text = "Computers";
            // 
            // lsvComputers
            // 
            lsvComputers.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lsvComputers.FullRowSelect = true;
            lsvComputers.Location = new Point(6, 22);
            lsvComputers.Name = "lsvComputers";
            lsvComputers.Size = new Size(434, 398);
            lsvComputers.TabIndex = 0;
            lsvComputers.UseCompatibleStateImageBehavior = false;
            lsvComputers.View = View.Details;
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
            // grbInfo
            // 
            grbInfo.Controls.Add(lblComment);
            grbInfo.Controls.Add(lblStatus);
            grbInfo.Controls.Add(lblType);
            grbInfo.Controls.Add(lblDate);
            grbInfo.Controls.Add(lblPrice);
            grbInfo.Controls.Add(lblCustomer);
            grbInfo.Controls.Add(lblOrderID);
            grbInfo.Location = new Point(12, 163);
            grbInfo.Name = "grbInfo";
            grbInfo.Padding = new Padding(7);
            grbInfo.Size = new Size(324, 275);
            grbInfo.TabIndex = 5;
            grbInfo.TabStop = false;
            grbInfo.Text = "Order Information";
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.Location = new Point(10, 149);
            lblComment.MaximumSize = new Size(300, 110);
            lblComment.Name = "lblComment";
            lblComment.Padding = new Padding(3);
            lblComment.Size = new Size(155, 21);
            lblComment.TabIndex = 6;
            lblComment.Text = "Comment placeholder text";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(10, 128);
            lblStatus.Name = "lblStatus";
            lblStatus.Padding = new Padding(3);
            lblStatus.Size = new Size(81, 21);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Order Status:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(10, 107);
            lblType.Name = "lblType";
            lblType.Padding = new Padding(3);
            lblType.Size = new Size(73, 21);
            lblType.TabIndex = 4;
            lblType.Text = "Order Type:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(10, 86);
            lblDate.Name = "lblDate";
            lblDate.Padding = new Padding(3);
            lblDate.Size = new Size(73, 21);
            lblDate.TabIndex = 3;
            lblDate.Text = "Order Date:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(10, 65);
            lblPrice.Name = "lblPrice";
            lblPrice.Padding = new Padding(3);
            lblPrice.Size = new Size(70, 21);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Total Price:";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(10, 44);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Padding = new Padding(3);
            lblCustomer.Size = new Size(68, 21);
            lblCustomer.TabIndex = 1;
            lblCustomer.Text = "Customer:";
            // 
            // lblOrderID
            // 
            lblOrderID.AutoSize = true;
            lblOrderID.Location = new Point(10, 23);
            lblOrderID.Name = "lblOrderID";
            lblOrderID.Padding = new Padding(3);
            lblOrderID.Size = new Size(60, 21);
            lblOrderID.TabIndex = 0;
            lblOrderID.Text = "Order ID:";
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbInfo);
            Controls.Add(grbActions);
            Controls.Add(grbComputers);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmOrder";
            Text = "Order Details";
            Load += frmOrder_Load;
            grbActions.ResumeLayout(false);
            grbComputers.ResumeLayout(false);
            grbInfo.ResumeLayout(false);
            grbInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbActions;
        private Button btnOrderNewComputer;
        private GroupBox grbComputers;
        private ListView lsvComputers;
        private GroupBox grbInfo;
        private Button btnChangeStatus;
        private Label lblCustomer;
        private Label lblOrderID;
        private Label lblComment;
        private Label lblStatus;
        private Label lblType;
        private Label lblDate;
        private Label lblPrice;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnComputerDetails;
        private Button btnCustomerDetails;
    }
}