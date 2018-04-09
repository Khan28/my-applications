using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_BulKareyiAlParayı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] tekrarsızSayılar = new int[4];
        private void tekrarOunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image=ımageList1.Images[0];
            //pictureBox2.Image = ımageList1.Images[1];
            //pictureBox3.Image = ımageList1.Images[2];
            //pictureBox4.Image = ımageList1.Images[3];
            //((PictureBox)this.Controls["pictureBox1"]).Image = ımageList1.Images[0];
            //((PictureBox)this.Controls["pictureBox2"]).Image = ımageList1.Images[1];
            //((PictureBox)this.Controls["pictureBox3"]).Image = ımageList1.Images[2];
            //((PictureBox)this.Controls["pictureBox4"]).Image = ımageList1.Images[3];
            Random rnd = new Random();
            //tekrarsız sayıların üretiliği kod bloğu
           
            for (int i = 0; i < 4; i++)
            {
                tekrarsızSayılar[i] = 5;
            }
            for (int i = 0; i < 4; i++)
            {
                int sayı;
                do
                {
                   sayı=rnd.Next(0,4); 
                } while (Array.IndexOf(tekrarsızSayılar,sayı)!=-1);
                tekrarsızSayılar[i]=sayı;
            }
           
            for (int i = 0; i < 4; i++)
            {
                ((PictureBox)this.Controls["pictureBox"+(i+1)]).Image = ımageList1.Images[tekrarsızSayılar[i]];
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                ((PictureBox)this.Controls["pictureBox" + (i + 1)]).Image = ımageList1.Images[4];
            }
            timer1.Stop();
        }
        public void pictureboxSecim(object sender, EventArgs e)
        {
            PictureBox pbx = (PictureBox)sender;
            int no = Convert.ToInt32(pbx.Name.Substring(10))-1;
            if (tekrarsızSayılar[no]==3)
            {
                pbx.Image = ımageList1.Images[3];
               DialogResult dr=new DialogResult();
                dr=MessageBox.Show("KAZANDINIZ!! TEKRAR OYNAMAK İSTERMİSİNİZ?", "BAŞLIK", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr==DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    if(dr==DialogResult.No)
                    {
                        dr = MessageBox.Show("OYUNU KAPATMAK İSTERMİSİNİZ?", "BAŞLIK", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr==DialogResult.Yes)
                        {
                            Application.Exit();
                        }
                   
                    }
                }
            }
            else
            {
                pbx.Image = ımageList1.Images[tekrarsızSayılar[no]];
                MessageBox.Show("KAYBETTİNİZ!!!");
            }

        }

        
    }
}
