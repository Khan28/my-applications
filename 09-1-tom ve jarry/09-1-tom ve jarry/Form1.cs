using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_1_tom_ve_jarry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void kacmaOlayı(object sender, EventArgs e)
        {
            Random rnd=new Random();
            button1.Location = new Point(rnd.Next(1,this.Width-100), rnd.Next(1,this.Height-100));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Application.StartupPath);
             
            //Bitmap btmpRsm = new Bitmap(Properties.Resources.tom,25,25);
            //Bitmap btmpRsm = new Bitmap("C:\\Users\\inan\\Desktop\\tom.jpg");
            //Bitmap btmpRsm = new Bitmap(@"C:\Users\inan\Desktop\tom.jpg");
            //Bitmap btmpRsm = new Bitmap(new Bitmap(@"C:\Users\inan\Desktop\tom.jpg"),50,50);
            //Bitmap btmpRsm = new Bitmap(new Bitmap(Application.StartupPath+@"\tom.jpg"), 50, 50);
            Bitmap btmpRsm = new Bitmap(new Bitmap(Properties.Resources.tom), 25, 25);
            Cursor yeniCursor = new Cursor(btmpRsm.GetHicon());
            this.Cursor = yeniCursor;
            
        }
    }
}
