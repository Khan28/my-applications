using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_TasKagitMakas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button1.BackgroundImage=ımageList1.Images[0];
            button2.BackgroundImage = ımageList1.Images[1];
            button3.BackgroundImage = ımageList1.Images[2];
        }
        public string tkmBulucu(int sayı)
        {
            string tkm = "";
            switch (sayı)
            {
                case 0:
                    tkm = "KAĞIT";
                    break;
                case 1:
                    tkm = "MAKAS";
                    break;
                case 2:
                    tkm = "TAŞ";
                    break;
                default:
                    tkm = "YANLIŞ DEĞER";
                    break;
            }
            return tkm;

        }
        
        public void SonucBulucu()
        {
            if (lblOyuncu.Text == lblPc.Text)
            {
                lblSonuc.Text = "BERABERE";
            }
            if (lblOyuncu.Text == "TAŞ" && lblPc.Text == "KAĞIT")
            {
                lblSonuc.Text = "PC";
            }
            if (lblOyuncu.Text == "TAŞ" && lblPc.Text == "MAKAS")
            {
                lblSonuc.Text = "OYUNCU";
            }
            if (lblOyuncu.Text == "KAĞIT" && lblPc.Text == "TAŞ")
            {
                lblSonuc.Text = "OYUNCU";
            }           
            if (lblOyuncu.Text == "KAĞIT" && lblPc.Text == "MAKAS")
            {
                lblSonuc.Text = "PC";
            }
            if (lblOyuncu.Text == "MAKAS" && lblPc.Text == "TAŞ")
            {
                lblSonuc.Text = "PC";
            }
            if (lblOyuncu.Text == "MAKAS" && lblPc.Text == "KAĞIT")
            {
                lblSonuc.Text = "OYUNCU";
            }
           
        }
        Random rnd = new Random();
        int durak;
        private void ortak_Click(object sender, EventArgs e)
        {
           
            Button btn = (Button)sender;        
            //lblOyuncu.Text = tkmBulucu(Convert.ToInt32(btn.Name[6].ToString()) - 1);
            lblOyuncu.Text = tkmBulucu(Convert.ToInt32(btn.Name.Substring(6)) - 1);

            butonEnabledAcKapa();
            durak = rnd.Next(1, 20);
            say = 0;
            timer1.Start();           


        }
        int say=0;

        public void butonEnabledAcKapa()
        {
            button1.Enabled = !(button1.Enabled);
            button2.Enabled = !(button2.Enabled);
            button3.Enabled = !(button3.Enabled);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            button4.BackgroundImage=ımageList1.Images[say%3];
            lblPc.Text=tkmBulucu(say%3);
            say++;
            if (say==durak)
	        {
		        timer1.Stop();
                SonucBulucu();
                butonEnabledAcKapa();
	        }
        
        }
    }
}
