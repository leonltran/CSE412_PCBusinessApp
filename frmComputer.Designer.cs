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
            SuspendLayout();
            // 
            // lComputers
            // 
            lComputers.Location = new Point(12, 12);
            lComputers.Name = "lComputers";
            lComputers.Size = new Size(776, 426);
            lComputers.TabIndex = 0;
            lComputers.UseCompatibleStateImageBehavior = false;
            // 
            // frmComputer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lComputers);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmComputer";
            Text = "PC Builder";
            ResumeLayout(false);
        }

        #endregion

        private ListView lComputers;
    }
}