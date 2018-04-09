using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_SınıfYerlesim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void KontrolOlusrur()
        {
            int konX = 10, konY = 10;
            for (int i = 1; i <= 16; i++)
            {
                Button btn = new Button();
                btn.Name = "btn" + i;
                btn.Size =new Size(80,80);
                btn.Location = new Point(konX,konY);
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Click += btn_Click;
                btn.BackgroundImage = ımageList1.Images[i - 1];
                konX += 85;
                if (konX>265)
                {
                    konX = 10;
                    konY += 85;
                }
                this.Controls.Add(btn);

            }
         

        }
        int[] sayılar=new int[16];
        Random rnd = new Random();
       
        public void Karıstır(string tur)
        {
            int sayı;
            for (int i = 0; i <16; i++)
            {
                sayılar[i] = 30;
            }
            for (int i = 0; i <16; i++)
            {
                do
                {
                    sayı=rnd.Next(0,16); 
                } while (Array.IndexOf(sayılar,sayı)!=-1);
                sayılar[i] = sayı;                
            }
            for (int i = 0; i < 16; i++)
            {
                if (tur=="Sıralı")
                {
                    ((Button)this.Controls["btn" + (i + 1)]).BackgroundImage = ımageList1.Images[i];
                }else if(tur=="Karısık")
	                {
                        ((Button)this.Controls["btn" + (i + 1)]).BackgroundImage = ımageList1.Images[sayılar[i]];
	                }
            }
        }
        int tık = 0;
        Button btn1, btn2;
        Image img1, img2;
        
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (radioButton2.Checked)
            {
                tık ++;
                if (tık==1)
                {
                    btn1 = btn;
                    img1 = btn.BackgroundImage;
                }
                if (tık == 2)
                {
                    btn2 = btn;
                    img2 = btn.BackgroundImage;
                    btn1.BackgroundImage = img2;
                    btn2.BackgroundImage = img1;
                    tık = 0;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KontrolOlusrur();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (radioButton4.Checked)
                {
                    Karıstır("Sıralı");
                }
                else if (radioButton3.Checked)
                {
                    Karıstır("Karısık");
                } 
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    this.BackColor = Color.Red;
                    break;
                case 1: this.BackColor = Color.Yellow;
                    break;            

            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                this.Opacity = 0.5;
            }
            else
            {
                this.Opacity = 1;
            }
        }

       
    }
}
