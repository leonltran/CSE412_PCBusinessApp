namespace CSE412_PCBusinessApp
{
    partial class frmDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDelete));
            gbItemInfo = new GroupBox();
            label1 = new Label();
            cbItemUID = new ComboBox();
            labelItemType = new Label();
            cbDelType = new ComboBox();
            gbResult = new GroupBox();
            btnDeleteItem = new Button();
            gbItemInfo.SuspendLayout();
            SuspendLayout();
            // 
            // gbItemInfo
            // 
            gbItemInfo.Controls.Add(label1);
            gbItemInfo.Controls.Add(cbItemUID);
            gbItemInfo.Controls.Add(labelItemType);
            gbItemInfo.Controls.Add(cbDelType);
            gbItemInfo.Location = new Point(12, 12);
            gbItemInfo.Name = "gbItemInfo";
            gbItemInfo.Size = new Size(231, 377);
            gbItemInfo.TabIndex = 0;
            gbItemInfo.TabStop = false;
            gbItemInfo.Text = "Item Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 80);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "Unique Id";
            // 
            // cbItemUID
            // 
            cbItemUID.FormattingEnabled = true;
            cbItemUID.Location = new Point(6, 98);
            cbItemUID.Name = "cbItemUID";
            cbItemUID.Size = new Size(121, 23);
            cbItemUID.TabIndex = 2;
            // 
            // labelItemType
            // 
            labelItemType.AutoSize = true;
            labelItemType.Location = new Point(6, 21);
            labelItemType.Name = "labelItemType";
            labelItemType.Size = new Size(58, 15);
            labelItemType.TabIndex = 1;
            labelItemType.Text = "Item Type";
            // 
            // cbDelType
            // 
            cbDelType.FormattingEnabled = true;
            cbDelType.Items.AddRange(new object[] { "Customer", "Order", "Computer", "Part" });
            cbDelType.Location = new Point(6, 39);
            cbDelType.Name = "cbDelType";
            cbDelType.Size = new Size(121, 23);
            cbDelType.TabIndex = 0;
            // 
            // gbResult
            // 
            gbResult.Location = new Point(249, 12);
            gbResult.Name = "gbResult";
            gbResult.Size = new Size(539, 426);
            gbResult.TabIndex = 1;
            gbResult.TabStop = false;
            gbResult.Text = "Search Result";
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new Point(12, 395);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(231, 43);
            btnDeleteItem.TabIndex = 2;
            btnDeleteItem.Text = "Delete Selected Item";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // frmDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteItem);
            Controls.Add(gbResult);
            Controls.Add(gbItemInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDelete";
            Text = "Delete Item";
            gbItemInfo.ResumeLayout(false);
            gbItemInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbItemInfo;
        private ComboBox cbDelType;
        private GroupBox gbResult;
        private Label labelItemType;
        private Label label1;
        private ComboBox cbItemUID;
        private Button btnDeleteItem;
    }
}