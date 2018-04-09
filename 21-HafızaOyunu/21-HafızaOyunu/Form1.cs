using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_HafızaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void resimKutusuOlustur()
        {
            int konX = 5, konY = 5;

            for (int i = 1; i < 37; i++)
            {
                PictureBox pbx = new PictureBox();
                pbx.Name = "pbx"+i;
                pbx.Width = 75;
                pbx.Height = 75;
                pbx.Location = new Point(konX, konY);
                konX += 75;
                pbx.Image = ımageList1.Images[0];
                pbx.Click += pbx_Click;
                this.Controls.Add(pbx);
                //if (konX <380)
                //{
                //    konX += 75;

                //}
                //else
                //{
                //    konX = 5;
                //    konY += 75;
                //}
                if (i%6==0)
                {
                    konX = 5;
                    konY +=75;
                }
            }

        }
        Random rnd = new Random();
        List<PictureBox> secilenPictureBox = new List<PictureBox>();
        void resimKarıstır()
        {
           
            while (secilenPictureBox.Count != 36)
            {
                int no = rnd.Next(1, 37);
                if (secilenPictureBox.Contains(((PictureBox)this.Controls["pbx" + no])) == false)
                {
                    secilenPictureBox.Add(((PictureBox)this.Controls["pbx" + no]));
                }
            }
            int sıra = 0;
            for (int i = 0; i < 18; i++)
            {

                for (int j = 0; j < 2; j++)
                {
                    secilenPictureBox[sıra].Image = ımageList1.Images[i];
                    sıra++;
                }
            }
        }
        public int  arama(PictureBox pbx)
        {
            int no=-1;
            for (int i = 0; i < 36; i++)
            {
                if (secilenPictureBox[i]==pbx)
                {
                   no=i;
                    break;
                }  
            }
            return no;
        }

        int tık = 1, secilenpbxindexno1, secilenpbxindexno2;
        void pbx_Click(object sender, EventArgs e)
        {
            PictureBox pbx = (PictureBox)sender;
            if (tık==1)
            {
                int secilenpbxindexno1 = arama(pbx);
                tık=2;
            }
            else if (tık==2)
            {
                int secilenpbxindexno2 = arama(pbx);
                tık = 1;

            }
           
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resimKutusuOlustur();
            resimKarıstır();
            for (int i = 0; i <36; i++)
            {
                listBox1.Items.Add(i+" - "+secilenPictureBox[i].Name);
            }
        }

        private void karıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resimKarıstır();
        }
    }
}
