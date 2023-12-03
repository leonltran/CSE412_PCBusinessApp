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
            button1 = new Button();
            btnOrderNewComputer = new Button();
            grbComputers = new GroupBox();
            listView1 = new ListView();
            grbInfo = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            grbComputers.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnOrderNewComputer);
            groupBox1.Location = new Point(12, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(7);
            groupBox1.Size = new Size(324, 139);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actions";
            // 
            // button1
            // 
            button1.Location = new Point(10, 82);
            button1.Name = "button1";
            button1.Size = new Size(304, 50);
            button1.TabIndex = 2;
            button1.Text = "Change Order Status...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnOrderNewComputer
            // 
            btnOrderNewComputer.Location = new Point(10, 26);
            btnOrderNewComputer.Name = "btnOrderNewComputer";
            btnOrderNewComputer.Size = new Size(304, 50);
            btnOrderNewComputer.TabIndex = 1;
            btnOrderNewComputer.Text = "Add New Computer...";
            btnOrderNewComputer.UseVisualStyleBackColor = true;
            btnOrderNewComputer.Click += btnOrderNewComputer_Click;
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
            grbInfo.Location = new Point(12, 218);
            grbInfo.Name = "grbInfo";
            grbInfo.Padding = new Padding(7);
            grbInfo.Size = new Size(324, 220);
            grbInfo.TabIndex = 5;
            grbInfo.TabStop = false;
            grbInfo.Text = "Order Information";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(7);
            groupBox2.Size = new Size(324, 55);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Select Order";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 29);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Order Id:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(69, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 23);
            comboBox1.TabIndex = 0;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(grbInfo);
            Controls.Add(groupBox1);
            Controls.Add(grbComputers);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmOrder";
            Text = "Order Details";
            groupBox1.ResumeLayout(false);
            grbComputers.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnOrderNewComputer;
        private GroupBox grbComputers;
        private ListView listView1;
        private GroupBox grbInfo;
        private Button button1;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox comboBox1;
    }
}