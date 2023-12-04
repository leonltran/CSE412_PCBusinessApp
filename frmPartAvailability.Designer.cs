namespace CSE412_PCBusinessApp
{
    partial class frmPartAvailability
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
            gbItemInfo = new GroupBox();
            labPartName = new Label();
            cbPartName = new ComboBox();
            gbQuantities = new GroupBox();
            gbPartInfo = new GroupBox();
            lbPartPrice = new Label();
            lbPartType = new Label();
            lbPartId = new Label();
            lbPartName = new Label();
            lPartStock = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            gbItemInfo.SuspendLayout();
            gbQuantities.SuspendLayout();
            gbPartInfo.SuspendLayout();
            SuspendLayout();
            // 
            // gbItemInfo
            // 
            gbItemInfo.Controls.Add(labPartName);
            gbItemInfo.Controls.Add(cbPartName);
            gbItemInfo.Location = new Point(12, 12);
            gbItemInfo.Name = "gbItemInfo";
            gbItemInfo.Size = new Size(776, 56);
            gbItemInfo.TabIndex = 1;
            gbItemInfo.TabStop = false;
            gbItemInfo.Text = "Part Search";
            // 
            // labPartName
            // 
            labPartName.AutoSize = true;
            labPartName.Location = new Point(6, 25);
            labPartName.Name = "labPartName";
            labPartName.Size = new Size(63, 15);
            labPartName.TabIndex = 3;
            labPartName.Text = "Part Name";
            // 
            // cbPartName
            // 
            cbPartName.FormattingEnabled = true;
            cbPartName.Location = new Point(75, 22);
            cbPartName.Name = "cbPartName";
            cbPartName.Size = new Size(695, 23);
            cbPartName.TabIndex = 2;
            cbPartName.KeyPress += cbPartName_KeyPress;
            // 
            // gbQuantities
            // 
            gbQuantities.Controls.Add(gbPartInfo);
            gbQuantities.Controls.Add(lPartStock);
            gbQuantities.Location = new Point(12, 74);
            gbQuantities.Name = "gbQuantities";
            gbQuantities.Size = new Size(776, 364);
            gbQuantities.TabIndex = 2;
            gbQuantities.TabStop = false;
            gbQuantities.Text = "Part Stock";
            // 
            // gbPartInfo
            // 
            gbPartInfo.Controls.Add(lbPartPrice);
            gbPartInfo.Controls.Add(lbPartType);
            gbPartInfo.Controls.Add(lbPartId);
            gbPartInfo.Controls.Add(lbPartName);
            gbPartInfo.Location = new Point(463, 22);
            gbPartInfo.Name = "gbPartInfo";
            gbPartInfo.Size = new Size(307, 336);
            gbPartInfo.TabIndex = 2;
            gbPartInfo.TabStop = false;
            gbPartInfo.Text = "Part Information";
            // 
            // lbPartPrice
            // 
            lbPartPrice.AutoSize = true;
            lbPartPrice.Location = new Point(27, 189);
            lbPartPrice.Name = "lbPartPrice";
            lbPartPrice.Size = new Size(36, 15);
            lbPartPrice.TabIndex = 3;
            lbPartPrice.Text = "Price:";
            // 
            // lbPartType
            // 
            lbPartType.AutoSize = true;
            lbPartType.Location = new Point(27, 134);
            lbPartType.Name = "lbPartType";
            lbPartType.Size = new Size(34, 15);
            lbPartType.TabIndex = 2;
            lbPartType.Text = "Type:";
            // 
            // lbPartId
            // 
            lbPartId.AutoSize = true;
            lbPartId.Location = new Point(27, 86);
            lbPartId.Name = "lbPartId";
            lbPartId.Size = new Size(45, 15);
            lbPartId.TabIndex = 1;
            lbPartId.Text = "Part ID:";
            // 
            // lbPartName
            // 
            lbPartName.AutoSize = true;
            lbPartName.Location = new Point(27, 42);
            lbPartName.Name = "lbPartName";
            lbPartName.Size = new Size(42, 15);
            lbPartName.TabIndex = 0;
            lbPartName.Text = "Name:";
            // 
            // lCompDetails
            // 
            lPartStock.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lPartStock.FullRowSelect = true;
            lPartStock.Location = new Point(6, 22);
            lPartStock.Name = "lCompDetails";
            lPartStock.Size = new Size(451, 336);
            lPartStock.TabIndex = 0;
            lPartStock.UseCompatibleStateImageBehavior = false;
            lPartStock.View = View.Details;
            lPartStock.SelectedIndexChanged += lPartStock_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Manufacturer";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Quantity";
            columnHeader3.Width = 70;
            // 
            // frmPartAvailability
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbQuantities);
            Controls.Add(gbItemInfo);
            Name = "frmPartAvailability";
            Text = "frmPartAvailability";
            Load += frmPartAvailability_Load;
            gbItemInfo.ResumeLayout(false);
            gbItemInfo.PerformLayout();
            gbQuantities.ResumeLayout(false);
            gbPartInfo.ResumeLayout(false);
            gbPartInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbItemInfo;
        private Label labPartName;
        private ComboBox cbPartName;
        private GroupBox gbQuantities;
        private ListView lPartStock;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private GroupBox gbPartInfo;
        private Label lbPartName;
        private Label lbPartPrice;
        private Label lbPartType;
        private Label lbPartId;
    }
}