using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_puzzle_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void PictureBoxOlustur()
        {
            int konX = 50, konY = 50;
            for (int i = 1; i <= 4; i++)
            {
                PictureBox pbx = new PictureBox();
                pbx.Name = "pbx" + i;
                pbx.Size = new Size(200, 200);
                pbx.Location = new Point(konX,konY);
                pbx.SizeMode = PictureBoxSizeMode.StretchImage;
                pbx.Image = ımageList1.Images[i-1];
                pbx.Click += pbx_Click;
                this.Controls.Add(pbx);
                konX += 200;
                if (konX>250)
                {
                    konX = 50;
                    konY += 200;
                }
                
            }    
                       
        }
        int tık = 0;
        Image res1, res2;
        PictureBox pb1, pb2;
        void pbx_Click(object sender, EventArgs e)
        {
            PictureBox pbx = (PictureBox)sender;
            tık++;
            if (tık==1)
            {
                res1 = pbx.Image;
                pb1 = pbx;
            }
            else if(tık==2)
            {
                res2 = pbx.Image;
                pb2 = pbx;
                tık = 0;
                pb1.Image = res2;
                pb2.Image = res1;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBoxOlustur();
            
        }

        private void resimleriKarıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] sayılar=new int[4];
            for (int i = 0; i < 4; i++)
            {
                sayılar[i] = 5;
            }
            Random rnd = new Random();
            int sayı;
            for (int i = 0; i < 4; i++)
            {
                do
                {
                    sayı = rnd.Next(0, 4);
                } while (Array.IndexOf(sayılar,sayı)!=-1);
                sayılar[i]=sayı;
            }
            for (int i = 0; i < 4; i++)
			{
                ((PictureBox)this.Controls["pbx" + (i + 1)]).Image = ımageList1.Images[sayılar[i]];
			}



        }
    }
}
