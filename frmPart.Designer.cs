namespace CSE412_PCBusinessApp
{
    partial class frmPart
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
            groupBox1 = new GroupBox();
            lParts = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            labPartName = new Label();
            cbPartName = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lParts);
            groupBox1.Location = new Point(12, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 403);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parts";
            // 
            // lParts
            // 
            lParts.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lParts.Location = new Point(6, 22);
            lParts.Name = "lParts";
            lParts.Size = new Size(764, 375);
            lParts.TabIndex = 2;
            lParts.UseCompatibleStateImageBehavior = false;
            lParts.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Part ID";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Type";
            columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Manufacturer";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Price";
            // 
            // labPartName
            // 
            labPartName.AutoSize = true;
            labPartName.Location = new Point(12, 9);
            labPartName.Name = "labPartName";
            labPartName.Size = new Size(55, 15);
            labPartName.TabIndex = 5;
            labPartName.Text = "Part Type";
            // 
            // cbPartName
            // 
            cbPartName.FormattingEnabled = true;
            cbPartName.Items.AddRange(new object[] { "All Parts", "CPU", "GPU", "HDD", "RAM", "SSD", "USB" });
            cbPartName.Location = new Point(81, 6);
            cbPartName.Name = "cbPartName";
            cbPartName.Size = new Size(695, 23);
            cbPartName.TabIndex = 4;
            cbPartName.SelectedIndexChanged += cbPartName_SelectedIndexChanged;
            // 
            // frmPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labPartName);
            Controls.Add(cbPartName);
            Controls.Add(groupBox1);
            Name = "frmPart";
            Text = "frmPart";
            Load += frmPart_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView lParts;
        private Label labPartName;
        private ComboBox cbPartName;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}