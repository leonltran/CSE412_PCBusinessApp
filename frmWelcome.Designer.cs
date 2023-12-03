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
            grbActions = new GroupBox();
            btnNewOrder = new Button();
            grbOrders = new GroupBox();
            lblTitle = new Label();
            grbActions.SuspendLayout();
            grbOrders.SuspendLayout();
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
            // btnNewOrder
            // 
            btnNewOrder.Location = new Point(10, 337);
            btnNewOrder.Name = "btnNewOrder";
            btnNewOrder.Size = new Size(304, 50);
            btnNewOrder.TabIndex = 2;
            btnNewOrder.Text = "Create New Order...\r\n";
            btnNewOrder.UseVisualStyleBackColor = true;
            btnNewOrder.Click += btnNewOrder_Click;
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
            Shown += Form1_Shown;
            grbActions.ResumeLayout(false);
            grbOrders.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button btnNewCustomer;
        private GroupBox grbActions;
        private Button btnNewOrder;
        private GroupBox grbOrders;
        private Label lblTitle;
    }
}