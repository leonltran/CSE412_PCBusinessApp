namespace CSE412_PCBusinessApp
{
    partial class frmComputer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComputer));
            lComputers = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // lComputers
            // 
            lComputers.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lComputers.FullRowSelect = true;
            lComputers.Location = new Point(180, 12);
            lComputers.Name = "lComputers";
            lComputers.Size = new Size(405, 426);
            lComputers.TabIndex = 0;
            lComputers.UseCompatibleStateImageBehavior = false;
            lComputers.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Computer ID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Order ID";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Type";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Weight";
            columnHeader4.Width = 100;
            // 
            // frmComputer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lComputers);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmComputer";
            Text = "Computers";
            Load += frmComputer_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lComputers;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}