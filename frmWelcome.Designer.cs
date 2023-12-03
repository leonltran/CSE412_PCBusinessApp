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
            listView1 = new ListView();
            btnNewCustomer = new Button();
            grbCustomer = new GroupBox();
            btnViewCustomer = new Button();
            grbOrders = new GroupBox();
            lblTitle = new Label();
            delItem = new Button();
            grbOrder = new GroupBox();
            btnEditOrder = new Button();
            btnNewOrder = new Button();
            grbComputer = new GroupBox();
            BtnComputerDetails = new Button();
            btnViewComputers = new Button();
            grbParts = new GroupBox();
            btnPartCheckAvail = new Button();
            btnViewParts = new Button();
            grbCustomer.SuspendLayout();
            grbOrders.SuspendLayout();
            grbOrder.SuspendLayout();
            grbComputer.SuspendLayout();
            grbParts.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(6, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(434, 398);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
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
            grbCustomer.Location = new Point(12, 36);
            grbCustomer.Name = "grbCustomer";
            grbCustomer.Padding = new Padding(7);
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
            btnViewCustomer.Click += button1_Click;
            // 
            // grbOrders
            // 
            grbOrders.Controls.Add(listView1);
            grbOrders.Location = new Point(342, 12);
            grbOrders.Name = "grbOrders";
            grbOrders.Size = new Size(446, 426);
            grbOrders.TabIndex = 3;
            grbOrders.TabStop = false;
            grbOrders.Text = "Orders";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblTitle.ImageAlign = ContentAlignment.TopLeft;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(252, 20);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Order Management - Welcome";
            // 
            // delItem
            // 
            delItem.Location = new Point(22, 408);
            delItem.Name = "delItem";
            delItem.Size = new Size(304, 30);
            delItem.TabIndex = 17;
            delItem.Text = "Delete Data Item...";
            delItem.UseVisualStyleBackColor = true;
            delItem.Click += delItem_Click;
            // 
            // grbOrder
            // 
            grbOrder.Controls.Add(btnEditOrder);
            grbOrder.Controls.Add(btnNewOrder);
            grbOrder.Location = new Point(12, 126);
            grbOrder.Name = "grbOrder";
            grbOrder.Padding = new Padding(7);
            grbOrder.Size = new Size(324, 91);
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
            grbComputer.Controls.Add(BtnComputerDetails);
            grbComputer.Controls.Add(btnViewComputers);
            grbComputer.Location = new Point(12, 215);
            grbComputer.Name = "grbComputer";
            grbComputer.Padding = new Padding(7);
            grbComputer.Size = new Size(324, 91);
            grbComputer.TabIndex = 15;
            grbComputer.TabStop = false;
            grbComputer.Text = "Computers";
            // 
            // BtnComputerDetails
            // 
            BtnComputerDetails.Location = new Point(10, 54);
            BtnComputerDetails.Name = "BtnComputerDetails";
            BtnComputerDetails.Size = new Size(304, 30);
            BtnComputerDetails.TabIndex = 16;
            BtnComputerDetails.Text = "View Computer Details...\r\n";
            BtnComputerDetails.UseVisualStyleBackColor = true;
            BtnComputerDetails.Click += BtnComputerDetails_Click;
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
            grbParts.Padding = new Padding(7);
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
            // frmWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbParts);
            Controls.Add(grbComputer);
            Controls.Add(grbOrder);
            Controls.Add(delItem);
            Controls.Add(lblTitle);
            Controls.Add(grbCustomer);
            Controls.Add(grbOrders);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmWelcome";
            Text = "Order Management";
            Shown += Form1_Shown;
            grbCustomer.ResumeLayout(false);
            grbOrders.ResumeLayout(false);
            grbOrder.ResumeLayout(false);
            grbComputer.ResumeLayout(false);
            grbParts.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button btnNewCustomer;
        private GroupBox grbCustomer;
        private GroupBox grbOrders;
        private Label lblTitle;
        private Button btnViewCustomer;
        private Button delItem;
        private GroupBox grbOrder;
        private Button btnEditOrder;
        private Button btnNewOrder;
        private GroupBox grbComputer;
        private Button BtnComputerDetails;
        private Button btnViewComputers;
        private GroupBox grbParts;
        private Button btnPartCheckAvail;
        private Button btnViewParts;
    }
}