namespace Xball
{
    partial class Xball_Form
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
            this.ball = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.AutoCheck = false;
            this.ball.AutoSize = true;
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.Location = new System.Drawing.Point(84, 121);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(14, 13);
            this.ball.TabIndex = 0;
            this.ball.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kontrol
            // 
            this.kontrol.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.kontrol.BackColor = System.Drawing.Color.Magenta;
            this.kontrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kontrol.Location = new System.Drawing.Point(28, 358);
            this.kontrol.Name = "kontrol";
            this.kontrol.Size = new System.Drawing.Size(87, 27);
            this.kontrol.TabIndex = 1;
            this.kontrol.TabStop = false;
            this.kontrol.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(296, 393);
            this.Controls.Add(this.kontrol);
            this.Controls.Add(this.ball);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Cball_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button kontrol;
    }
}

