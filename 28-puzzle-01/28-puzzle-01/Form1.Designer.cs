namespace _28_puzzle_01
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oyunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimleriKarıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "şeftali 5.jpg");
            this.ımageList1.Images.SetKeyName(1, "şeftali 6.jpg");
            this.ımageList1.Images.SetKeyName(2, "şeftali 7.jpg");
            this.ımageList1.Images.SetKeyName(3, "şeftali 8.jpg");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oyunToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oyunToolStripMenuItem
            // 
            this.oyunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resimleriKarıştırToolStripMenuItem});
            this.oyunToolStripMenuItem.Name = "oyunToolStripMenuItem";
            this.oyunToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.oyunToolStripMenuItem.Text = "Oyun";
            // 
            // resimleriKarıştırToolStripMenuItem
            // 
            this.resimleriKarıştırToolStripMenuItem.Name = "resimleriKarıştırToolStripMenuItem";
            this.resimleriKarıştırToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.resimleriKarıştırToolStripMenuItem.Text = "Resimleri Karıştır";
            this.resimleriKarıştırToolStripMenuItem.Click += new System.EventHandler(this.resimleriKarıştırToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 481);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oyunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resimleriKarıştırToolStripMenuItem;
    }
}

