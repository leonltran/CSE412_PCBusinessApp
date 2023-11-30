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
            groupBox1 = new GroupBox();
            btnNewOrder = new Button();
            grbOrders = new GroupBox();
            groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNewCustomer);
            groupBox1.Controls.Add(btnNewOrder);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(7);
            groupBox1.Size = new Size(324, 426);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actions";
            // 
            // btnNewOrder
            // 
            btnNewOrder.Location = new Point(10, 366);
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
            // frmWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(grbOrders);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmWelcome";
            Text = "Order Management - Welcome";
            Shown += Form1_Shown;
            groupBox1.ResumeLayout(false);
            grbOrders.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button btnNewCustomer;
        private GroupBox groupBox1;
        private Button btnNewOrder;
        private GroupBox grbOrders;
    }
}