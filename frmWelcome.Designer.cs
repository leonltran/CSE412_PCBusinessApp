namespace CSE412_PCBusinessApp
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            lsvOrders = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnNewCustomer = new Button();
            grbCustomer = new GroupBox();
            btnViewCustomer = new Button();
            grbOrders = new GroupBox();
            btnEdit = new Button();
            btnDelete = new Button();
            grbOrder = new GroupBox();
            btnEditOrder = new Button();
            btnNewOrder = new Button();
            grbComputer = new GroupBox();
            btnComputerDetails = new Button();
            btnViewComputers = new Button();
            grbParts = new GroupBox();
            btnPartCheckAvail = new Button();
            btnViewParts = new Button();
            btnPassword = new Button();
            grbCustomer.SuspendLayout();
            grbOrders.SuspendLayout();
            grbOrder.SuspendLayout();
            grbComputer.SuspendLayout();
            grbParts.SuspendLayout();
            SuspendLayout();
            // 
            // lsvOrders
            // 
            lsvOrders.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvOrders.FullRowSelect = true;
            lsvOrders.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lsvOrders.Location = new Point(6, 22);
            lsvOrders.Name = "lsvOrders";
            lsvOrders.Size = new Size(434, 398);
            lsvOrders.TabIndex = 0;
            lsvOrders.UseCompatibleStateImageBehavior = false;
            lsvOrders.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "OrderID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Customer";
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Status";
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Date";
            columnHeader4.Width = 90;
            // 
            // btnNewCustomer
            // 
            btnNewCustomer.Location = new Point(10, 17);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(304, 30);
            btnNewCustomer.TabIndex = 1;
            btnNewCustomer.Text = "Add New Customer...";
            btnNewCustomer.UseVisualStyleBackColor = true;
            btnNewCustomer.Click += btnAddCustomer_Click;
            // 
            // grbCustomer
            // 
            grbCustomer.Controls.Add(btnViewCustomer);
            grbCustomer.Controls.Add(btnNewCustomer);
            grbCustomer.Location = new Point(12, 12);
            grbCustomer.Name = "grbCustomer";
            grbCustomer.Size = new Size(324, 91);
            grbCustomer.TabIndex = 2;
            grbCustomer.TabStop = false;
            grbCustomer.Text = "Customers";
            // 
            // btnViewCustomer
            // 
            btnViewCustomer.Location = new Point(10, 53);
            btnViewCustomer.Name = "btnViewCustomer";
            btnViewCustomer.Size = new Size(304, 30);
            btnViewCustomer.TabIndex = 3;
            btnViewCustomer.Text = "View Customer Information...";
            btnViewCustomer.UseVisualStyleBackColor = true;
            btnViewCustomer.Click += btnViewCustomer_Click;
            // 
            // grbOrders
            // 
            grbOrders.Controls.Add(lsvOrders);
            grbOrders.Location = new Point(342, 12);
            grbOrders.Name = "grbOrders";
            grbOrders.Size = new Size(446, 426);
            grbOrders.TabIndex = 3;
            grbOrders.TabStop = false;
            grbOrders.Text = "Orders";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(0, 0);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 412);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 26);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete Data Item...";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += delItem_Click;
            // 
            // grbOrder
            // 
            grbOrder.Controls.Add(btnEditOrder);
            grbOrder.Controls.Add(btnNewOrder);
            grbOrder.Location = new Point(12, 109);
            grbOrder.Name = "grbOrder";
            grbOrder.Size = new Size(324, 93);
            grbOrder.TabIndex = 4;
            grbOrder.TabStop = false;
            grbOrder.Text = "Orders";
            // 
            // btnEditOrder
            // 
            btnEditOrder.Location = new Point(10, 53);
            btnEditOrder.Name = "btnEditOrder";
            btnEditOrder.Size = new Size(304, 30);
            btnEditOrder.TabIndex = 14;
            btnEditOrder.Text = "View/Edit Order...";
            btnEditOrder.UseVisualStyleBackColor = true;
            btnEditOrder.Click += btnEditOrder_Click;
            // 
            // btnNewOrder
            // 
            btnNewOrder.Location = new Point(10, 17);
            btnNewOrder.Name = "btnNewOrder";
            btnNewOrder.Size = new Size(304, 30);
            btnNewOrder.TabIndex = 13;
            btnNewOrder.Text = "Create New Order...\r\n";
            btnNewOrder.UseVisualStyleBackColor = true;
            btnNewOrder.Click += btnNewOrder_Click_1;
            // 
            // grbComputer
            // 
            grbComputer.Controls.Add(btnComputerDetails);
            grbComputer.Controls.Add(btnViewComputers);
            grbComputer.Location = new Point(12, 208);
            grbComputer.Name = "grbComputer";
            grbComputer.Size = new Size(324, 91);
            grbComputer.TabIndex = 15;
            grbComputer.TabStop = false;
            grbComputer.Text = "Computers";
            // 
            // btnComputerDetails
            // 
            btnComputerDetails.Location = new Point(10, 54);
            btnComputerDetails.Name = "btnComputerDetails";
            btnComputerDetails.Size = new Size(304, 30);
            btnComputerDetails.TabIndex = 16;
            btnComputerDetails.Text = "View Computer Details...\r\n";
            btnComputerDetails.UseVisualStyleBackColor = true;
            btnComputerDetails.Click += BtnComputerDetails_Click;
            // 
            // btnViewComputers
            // 
            btnViewComputers.Location = new Point(10, 18);
            btnViewComputers.Name = "btnViewComputers";
            btnViewComputers.Size = new Size(304, 30);
            btnViewComputers.TabIndex = 15;
            btnViewComputers.Text = "View All Computers...";
            btnViewComputers.UseVisualStyleBackColor = true;
            btnViewComputers.Click += btnViewComputers_Click;
            // 
            // grbParts
            // 
            grbParts.Controls.Add(btnPartCheckAvail);
            grbParts.Controls.Add(btnViewParts);
            grbParts.Location = new Point(12, 305);
            grbParts.Name = "grbParts";
            grbParts.Size = new Size(324, 91);
            grbParts.TabIndex = 17;
            grbParts.TabStop = false;
            grbParts.Text = "Parts";
            // 
            // btnPartCheckAvail
            // 
            btnPartCheckAvail.Location = new Point(10, 54);
            btnPartCheckAvail.Name = "btnPartCheckAvail";
            btnPartCheckAvail.Size = new Size(304, 30);
            btnPartCheckAvail.TabIndex = 18;
            btnPartCheckAvail.Text = "View Part Availability...";
            btnPartCheckAvail.UseVisualStyleBackColor = true;
            btnPartCheckAvail.Click += btnPartCheckAvail_Click;
            // 
            // btnViewParts
            // 
            btnViewParts.Location = new Point(10, 18);
            btnViewParts.Name = "btnViewParts";
            btnViewParts.Size = new Size(304, 30);
            btnViewParts.TabIndex = 17;
            btnViewParts.Text = "View All Parts...";
            btnViewParts.UseVisualStyleBackColor = true;
            btnViewParts.Click += btnViewParts_Click;
            // 
            // btnPassword
            // 
            btnPassword.Location = new Point(186, 412);
            btnPassword.Name = "btnPassword";
            btnPassword.Size = new Size(150, 26);
            btnPassword.TabIndex = 18;
            btnPassword.Text = "Config DB Password";
            btnPassword.UseVisualStyleBackColor = true;
            btnPassword.Click += btnPassword_Click;
            // 
            // frmWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPassword);
            Controls.Add(grbParts);
            Controls.Add(grbComputer);
            Controls.Add(grbOrder);
            Controls.Add(btnDelete);
            Controls.Add(grbCustomer);
            Controls.Add(grbOrders);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmWelcome";
            Text = "Order Management - Welcome";
            Load += frmWelcome_Load;
            grbCustomer.ResumeLayout(false);
            grbOrders.ResumeLayout(false);
            grbOrder.ResumeLayout(false);
            grbComputer.ResumeLayout(false);
            grbParts.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView lsvOrders;
        private Button btnNewCustomer;
        private GroupBox grbCustomer;
        private GroupBox grbOrders;
        private Button btnViewCustomer;
        private Button btnDelete;
        private GroupBox grbOrder;
        private Button btnEditOrder;
        private Button btnNewOrder;
        private GroupBox grbComputer;
        private Button btnComputerDetails;
        private Button btnViewComputers;
        private GroupBox grbParts;
        private Button btnPartCheckAvail;
        private Button btnViewParts;
        private Button btnEdit;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader3;
        private Button btnPassword;
    }
}