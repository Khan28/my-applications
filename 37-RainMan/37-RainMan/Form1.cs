using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _37_RainMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void KontrolHareket(PreviewKeyDownEventArgs e, PictureBox pbx)
        {            
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        if (pbx.Left>15)
                        {
                            pbx.Location = new Point(pbx.Location.X - 5, pbx.Location.Y);                           
                        }
                        break;
                    case Keys.A:
                        if (pbx.Left > 15)
                        {
                            pbx.Location = new Point(pbx.Location.X - 5, pbx.Location.Y);
                        }
                        break;
                    case Keys.Right:
                        if (pbx.Left < (this.Width-97))
                        {
                            pbx.Location = new Point(pbx.Location.X + 5, pbx.Location.Y);
                        }                        
                        break;
                    case Keys.D:
                        if (pbx.Left < (this.Width - 97))
                        {
                            pbx.Location = new Point(pbx.Location.X + 5, pbx.Location.Y);
                        }                        
                        break; 
                }
            
        }
        int no = 1;
        Random rnd = new Random();
        List<PictureBox> damlalar=new List<PictureBox>();
        public void DamlaOlustur()
        {
            PictureBox damla = new PictureBox();
            damla.Name = "damla"+no;
            no++;
            damla.Size = new Size(30, 30);
            damla.Image = Resource1.damla2;
            damla.SizeMode = PictureBoxSizeMode.StretchImage;           
            damla.Location = new Point(rnd.Next(15,this.Width-100),20);
            damla.BringToFront();
            damlalar.Add(damla);
            this.Controls.Add(damla);
            timerHareket.Start();
        }

        private void pbxKova_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           KontrolHareket(e, pbxKova);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            pbxKova.Select();
            pbxKova.Location=new Point(this.Width/2,this.Height-100);
            timerDamlaOlustur.Start();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pbxKova.Select();
            pbxKova.Location = new Point((this.Width / 2)-50, this.Height - 110);
        }

        private void timerHareket_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < damlalar.Count; i++)
            {
                //((PictureBox)this.Controls["damla" + damlalar[i]]).Location = new Point(((PictureBox)this.Controls["damla" + damlalar[i]]).Location.X, ((PictureBox)this.Controls["damla" + damlalar[i]]).Location.Y + 5);
                damlalar[i].Location = new Point(damlalar[i].Location.X, damlalar[i].Location.Y+5);
            }
            CarpısmaKontrol();
        }
        public bool Carpısma(PictureBox nesne1, PictureBox nesne2)
        {
            bool sonuc = false;
            if (nesne1.Right > nesne2.Left && nesne1.Bottom > nesne2.Top && nesne1.Left < nesne2.Right && nesne1.Top < nesne2.Bottom)
            {
                sonuc = true;
            }
            return sonuc;

        }
        int skor = 0;
        public void CarpısmaKontrol()
        {
            
            for (int i = 0; i < damlalar.Count; i++)
            {
                if (Carpısma(pbxKova, damlalar[i]))
                {
                    this.Controls.Remove(damlalar[i]);
                    damlalar.Remove(damlalar[i]);
                    skor++;
                    label1.Text = skor.ToString();
                }
            }
        }
        private void timerDamlaOlustur_Tick(object sender, EventArgs e)
        {
            DamlaOlustur();
        }
    }
}
