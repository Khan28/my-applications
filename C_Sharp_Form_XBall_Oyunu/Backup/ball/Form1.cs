using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Xball
{
    public partial class Xball_Form : Form
    {
        int yerX = 5,yerY=5;
        ArrayList kutucuklar = new ArrayList();
        int kutuSayisi = 5;
        int Hak = 3;
        int Level = 1;
        int hareket = 5;

        public Xball_Form()
        {
            InitializeComponent();
        }

        private void Cball_Load(object sender, EventArgs e)
        {
            this.Text = "Seviye : " + Level.ToString() + "   Kalan hakkınız :" + Hak.ToString();
            Yenile();
            kutucuklarOlustur();
        }

        private void Yenile()
        {
            kutuSayisi = 5 * Level;
            Random rdn = new Random();
            int x = rdn.Next(0, 50);
            int y = rdn.Next(150, 250);
            ball.Location = new Point(x, y);
            timer1.Enabled = true;
            timer1.Interval = 5;
            yerX = 1 + Level * 1;
            yerY = -1 - Level * 1;
            if (yerX < 0)
                hareket = yerX * -1;
            else
                hareket = yerX;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Application.DoEvents();
            ballHareket();
            carpmaDenetimi();
            oyunBittiMi(sender, e);
            KalanHak(sender, e);
        }

        private void KalanHak(object sender, EventArgs e)
        {
            if (ball.Bottom > kontrol.Bottom - 15 && !(ball.Right >= kontrol.Left && ball.Left <= kontrol.Right))
            {
                Hak--;
                
                for (int i = 0; i < kutucuklar.Count; i++)
                {
                    Button btn = ((Button)kutucuklar[i]);
                    ((Button)kutucuklar[i]).Dispose();
                }
                kutucuklar.Clear();
                timer1.Enabled = false;
                DialogResult dr = DialogResult.None;
                if (Hak > 0)
                {
                    dr=MessageBox.Show("Yandınız. Kalan hakkınız : " + Hak.ToString());                   
                    if(dr ==DialogResult.OK)
                        Cball_Load(sender, e);
                }
                else if (Hak == 0)
                {
                    MessageBox.Show("GameOver");
                    this.Close();
                }
            }
        }

        private void oyunBittiMi(object sender, EventArgs e)
        {
            DialogResult dr = DialogResult.None;
            if (kutuSayisi == 0)
            {
                timer1.Enabled = false;
                dr = MessageBox.Show("Tebrikler. Seviye "+Level+" Bitirdiniz. ");
                Level++;
            }
            if (dr == DialogResult.OK)
                Cball_Load(sender, e);
        }

        private void ballHareket()
        {
            if (this.ClientSize.Width <= ball.Right)
            {
                yerX = yerX * -1;
            }
            else if (0 >= ball.Left)
            {
                yerX = yerX * -1;
            }

            if (this.ClientSize.Height <= ball.Bottom)
            {
                yerY = yerY * -1;
            }
            else if (0 >= ball.Top)
            {
                yerY = yerY * -1;
            }
            else if (ball.Bottom >= kontrol.Top + 5 && ball.Right >= kontrol.Left && ball.Left <= kontrol.Right)
            {
                yerY = yerY * -1;
            }

            ball.Location = new System.Drawing.Point(ball.Left + yerX, ball.Top + yerY);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            kontrol.Left = e.X;
        }

        private void kutucuklarOlustur()
        {
            for (int j = 0; j < Level; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Button btn = new Button();
                    btn.Name = i.ToString();
                    btn.TabStop = false;
                    btn.Select();
                    btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn.Location = new Point(20 + i * 50, j*40+20 );
                    btn.Width = 40;
                    btn.BackColor = Color.Red;
                    this.Controls.Add(btn);
                    kutucuklar.Add(btn);
                }
            }
        }

        private void carpmaDenetimi() 
        {
            Rectangle r = new Rectangle();
            Rectangle t = new Rectangle();
			    t.X=ball.Left;
                t.Y=ball.Top;
                t.Height=ball.Height;
                t.Width=ball.Width;
            for (int i = 0; i < kutucuklar.Count; i++)
			{
                Button btn =((Button)kutucuklar[i]);
			    r.X=btn.Left;
                r.Y=btn.Top;
                r.Height=btn.Height;
                r.Width=btn.Width;
                if (r.IntersectsWith(t))
                {
                    kutuSayisi--;

                    kutucuklar.RemoveAt(i);
                    if (yerY > 0 && yerX >0)
                    {
                        if (btn.Top <= ball.Bottom && btn.Left < ball.Right - hareket)
                            yerY = yerY * -1;
                        else
                            yerX = yerX * -1;
                    }
                    else
                        if (yerY > 0 && yerX < 0)
                        {
                            if (btn.Top <= ball.Bottom && btn.Right > ball.Left + hareket)
                                yerY = yerY * -1;
                            else
                                yerX = yerX * -1;
                        }
                        else
                            if (yerY < 0 && yerX > 0)
                            {
                                if (btn.Bottom >= ball.Top && btn.Left < ball.Right - hareket)
                                    yerY = yerY * -1;
                                else
                                    yerX = yerX * -1;
                            }
                            else
                                if (yerY < 0 && yerX < 0)
                                {
                                    if (btn.Bottom >= ball.Top && btn.Right > ball.Left + hareket)
                                        yerY = yerY * -1;
                                    else
                                        yerX = yerX * -1;
                                }


                    btn.Dispose();
                }
                Application.DoEvents();
			}
        }

    }
}
