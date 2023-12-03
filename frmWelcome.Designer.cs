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
            grbActions = new GroupBox();
            btnPassword = new Button();
            btnNewOrder = new Button();
            grbOrders = new GroupBox();
            btnDelete = new Button();
            btnEdit = new Button();
            lblTitle = new Label();
            grbActions.SuspendLayout();
            grbOrders.SuspendLayout();
            SuspendLayout();
            // 
            // lsvOrders
            // 
            lsvOrders.Activation = ItemActivation.OneClick;
            lsvOrders.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvOrders.FullRowSelect = true;
            lsvOrders.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lsvOrders.Location = new Point(6, 22);
            lsvOrders.Name = "lsvOrders";
            lsvOrders.Size = new Size(434, 369);
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
            columnHeader2.Width = 180;
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
            btnNewCustomer.Location = new Point(10, 26);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(304, 50);
            btnNewCustomer.TabIndex = 1;
            btnNewCustomer.Text = "Add New Customer...";
            btnNewCustomer.UseVisualStyleBackColor = true;
            btnNewCustomer.Click += btnAddCustomer_Click;
            // 
            // grbActions
            // 
            grbActions.Controls.Add(btnPassword);
            grbActions.Controls.Add(btnNewCustomer);
            grbActions.Controls.Add(btnNewOrder);
            grbActions.Location = new Point(12, 41);
            grbActions.Name = "grbActions";
            grbActions.Padding = new Padding(7);
            grbActions.Size = new Size(324, 397);
            grbActions.TabIndex = 2;
            grbActions.TabStop = false;
            grbActions.Text = "Actions";
            // 
            // btnPassword
            // 
            btnPassword.Location = new Point(10, 364);
            btnPassword.Name = "btnPassword";
            btnPassword.Size = new Size(304, 23);
            btnPassword.TabIndex = 3;
            btnPassword.Text = "Configure Database Password";
            btnPassword.UseVisualStyleBackColor = true;
            btnPassword.Click += btnPassword_Click;
            // 
            // btnNewOrder
            // 
            btnNewOrder.Location = new Point(10, 82);
            btnNewOrder.Name = "btnNewOrder";
            btnNewOrder.Size = new Size(304, 50);
            btnNewOrder.TabIndex = 2;
            btnNewOrder.Text = "Create New Order...\r\n";
            btnNewOrder.UseVisualStyleBackColor = true;
            btnNewOrder.Click += btnNewOrder_Click;
            // 
            // grbOrders
            // 
            grbOrders.Controls.Add(btnDelete);
            grbOrders.Controls.Add(btnEdit);
            grbOrders.Controls.Add(lsvOrders);
            grbOrders.Location = new Point(342, 12);
            grbOrders.Name = "grbOrders";
            grbOrders.Size = new Size(446, 426);
            grbOrders.TabIndex = 3;
            grbOrders.TabStop = false;
            grbOrders.Text = "Orders";
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(6, 397);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(365, 397);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ImageAlign = ContentAlignment.TopLeft;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(279, 25);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Order Management - Welcome";
            // 
            // frmWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(grbActions);
            Controls.Add(grbOrders);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmWelcome";
            Text = "Order Management";
            Load += frmWelcome_Load;
            Shown += Form1_Shown;
            grbActions.ResumeLayout(false);
            grbOrders.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvOrders;
        private Button btnNewCustomer;
        private GroupBox grbActions;
        private Button btnNewOrder;
        private GroupBox grbOrders;
        private Label lblTitle;
        private Button btnEdit;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader3;
        private Button btnPassword;
        private Button btnDelete;
    }
}