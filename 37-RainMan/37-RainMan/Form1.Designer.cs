namespace _37_RainMan
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
            this.pbxKova = new System.Windows.Forms.PictureBox();
            this.timerHareket = new System.Windows.Forms.Timer(this.components);
            this.timerDamlaOlustur = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKova)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxKova
            // 
            this.pbxKova.Image = global::_37_RainMan.Resource1.kovaaa;
            this.pbxKova.Location = new System.Drawing.Point(444, 328);
            this.pbxKova.Name = "pbxKova";
            this.pbxKova.Size = new System.Drawing.Size(50, 50);
            this.pbxKova.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxKova.TabIndex = 0;
            this.pbxKova.TabStop = false;
            this.pbxKova.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pbxKova_PreviewKeyDown);
            // 
            // timerHareket
            // 
            this.timerHareket.Tick += new System.EventHandler(this.timerHareket_Tick);
            // 
            // timerDamlaOlustur
            // 
            this.timerDamlaOlustur.Interval = 3000;
            this.timerDamlaOlustur.Tick += new System.EventHandler(this.timerDamlaOlustur_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_37_RainMan.Resource1.mapp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(502, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxKova);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbxKova)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxKova;
        private System.Windows.Forms.Timer timerHareket;
        private System.Windows.Forms.Timer timerDamlaOlustur;
        private System.Windows.Forms.Label label1;
    }
}

