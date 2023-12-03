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
            groupBox1 = new GroupBox();
            btnNewComputer = new Button();
            grbComputers = new GroupBox();
            listView1 = new ListView();
            btnBack = new Button();
            grbInfo = new GroupBox();
            groupBox1.SuspendLayout();
            grbComputers.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNewComputer);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(7);
            groupBox1.Size = new Size(324, 91);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actions";
            // 
            // btnNewComputer
            // 
            btnNewComputer.Location = new Point(10, 26);
            btnNewComputer.Name = "btnNewComputer";
            btnNewComputer.Size = new Size(304, 50);
            btnNewComputer.TabIndex = 1;
            btnNewComputer.Text = "Add New Computer...";
            btnNewComputer.UseVisualStyleBackColor = true;
            btnNewComputer.Click += btnNewComputer_Click;
            // 
            // grbComputers
            // 
            grbComputers.Controls.Add(listView1);
            grbComputers.Location = new Point(342, 12);
            grbComputers.Name = "grbComputers";
            grbComputers.Size = new Size(446, 426);
            grbComputers.TabIndex = 5;
            grbComputers.TabStop = false;
            grbComputers.Text = "Computers";
            // 
            // listView1
            // 
            listView1.Location = new Point(6, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(434, 398);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // grbInfo
            // 
            grbInfo.Location = new Point(12, 138);
            grbInfo.Name = "grbInfo";
            grbInfo.Padding = new Padding(7);
            grbInfo.Size = new Size(324, 300);
            grbInfo.TabIndex = 5;
            grbInfo.TabStop = false;
            grbInfo.Text = "Order Information";
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbInfo);
            Controls.Add(btnBack);
            Controls.Add(groupBox1);
            Controls.Add(grbComputers);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmOrder";
            Text = "Order Details";
            groupBox1.ResumeLayout(false);
            grbComputers.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnNewComputer;
        private GroupBox grbComputers;
        private ListView listView1;
        private Button btnBack;
        private GroupBox grbInfo;
    }
}