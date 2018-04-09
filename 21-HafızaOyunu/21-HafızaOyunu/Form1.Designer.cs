namespace _21_HafızaOyunu
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
            this.karıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "miki.jpg");
            this.ımageList1.Images.SetKeyName(1, "jerry.jpg");
            this.ımageList1.Images.SetKeyName(2, "3.png");
            this.ımageList1.Images.SetKeyName(3, "4.png");
            this.ımageList1.Images.SetKeyName(4, "5.png");
            this.ımageList1.Images.SetKeyName(5, "6.png");
            this.ımageList1.Images.SetKeyName(6, "7.png");
            this.ımageList1.Images.SetKeyName(7, "8.png");
            this.ımageList1.Images.SetKeyName(8, "9.png");
            this.ımageList1.Images.SetKeyName(9, "10.png");
            this.ımageList1.Images.SetKeyName(10, "11.png");
            this.ımageList1.Images.SetKeyName(11, "12.png");
            this.ımageList1.Images.SetKeyName(12, "13.png");
            this.ımageList1.Images.SetKeyName(13, "14.png");
            this.ımageList1.Images.SetKeyName(14, "15.png");
            this.ımageList1.Images.SetKeyName(15, "16.png");
            this.ımageList1.Images.SetKeyName(16, "17.png");
            this.ımageList1.Images.SetKeyName(17, "18.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.karıştırToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // karıştırToolStripMenuItem
            // 
            this.karıştırToolStripMenuItem.Name = "karıştırToolStripMenuItem";
            this.karıştırToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.karıştırToolStripMenuItem.Text = "Karıştır";
            this.karıştırToolStripMenuItem.Click += new System.EventHandler(this.karıştırToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(537, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 329);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 478);
            this.Controls.Add(this.listBox1);
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
        private System.Windows.Forms.ToolStripMenuItem karıştırToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
    }
}

