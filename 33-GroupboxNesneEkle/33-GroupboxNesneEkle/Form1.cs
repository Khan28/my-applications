using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33_GroupboxNesneEkle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void btnOlustur()
        {
            int btnW = (groupBox1.Width - 20) / 3, btnH = (groupBox1.Height - 20) / 3;
          const  int sbtkonX = 10,sbtkonY = 10;
          int konX = sbtkonX, konY = sbtkonY;
            for (int i = 1; i <= 9; i++)
            {
                Button btn = new Button();
                btn.Name = "btn" + i;
                btn.Size = new Size(btnW,btnH);
                btn.Location = new Point(konX, konY);
                konX += btnW;
                if (i % 3 == 0)
                {
                    konX = sbtkonX;
                    konY += btnH;
                }
                this.groupBox1.Controls.Add(btn);
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            groupBox1.Size = new Size(this.Width-170,this.Height-60);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
      

        private void btnEkle_Click(object sender, EventArgs e)
        {
            btnOlustur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            this.groupBox1.Controls.Clear();
        }
    }
}
