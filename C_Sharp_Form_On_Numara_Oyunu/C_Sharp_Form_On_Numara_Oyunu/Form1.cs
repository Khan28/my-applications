using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_Sharp_Form_On_Numara_Oyunu
{
    public partial class OnNumaraForm : Form
    {
        int[] GelenSayilar = new int[10];

        private System.Windows.Forms.Button button1;

        // 10 tane seçilen sayıları yerleştirmek için textbox kutucukları oluşturma

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;


        // 80 numarada seçilen rasgele 10 numarayı yazdırmak  için listbox

        private System.Windows.Forms.ListBox listBox1;
 
        // Onnumara oyunu constructor: 

        public OnNumaraForm()
        {
            //form oluşturulurken komponentleri oluştur ve özelliklerini ayarla

            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            //Rastgele sayılar oluşturmak için random nesnesini kullanacağım.
            //Random nesnesinin bir örneğini oluşturuyorum

            Random random = new Random();

            // Rastgele 1 ile 80 arasýnda 10 tane rakam belirlemek için oluşturduğum
            // random nesnesini Next metosunu kullanacağım. Next metoduna parametre olarak
            // rasgele sayı oluşturmak istediğim aralığı veriyorum. Burada 1 ile 80 arasında
            // sayılar oluşturacak. Next metodunun sınırları almadığığı için 80 değerini 
            // 81 olarak olarak giriyorum

            for (int i = 0; i < 10; i++)
            {
                //Rastgele bir sayı oluşturuyorum ve bunu GelenSayilar dizisine ekliyorum
 
                GelenSayilar[i] = random.Next(1, 81);

                //Yeni oluşan sayı daha önce oluşup oluşmadığını kontrol etmek için
                //for döngüsü ile GelenSayilar dizisinin bütün elemanlarını kontrol ediyorum.
                //Eğer aynı sayı var ise i değerini 1 azaltarak bu sayının yeniden hesaplanmasını
                //sağlıyorum.

                for (int j = 0; j < i; j++)
                {
                    if (GelenSayilar[j] == GelenSayilar[i])
                    {
                        i--;
                    }
                }
            }

            //belirlenen 10 rakamı sıralamak için iç içe iki for döngüsü ile dizi elemanları
            //birbir ile karşılaştırıyorum. En küçük sayıyı en başa yerleştirerek sıralamayı
            //yapıyorum

            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (GelenSayilar[j] < GelenSayilar[i])
                    {
                        int sayi = GelenSayilar[j];
                        GelenSayilar[j] = GelenSayilar[i];
                        GelenSayilar[i] = sayi;
                    }
                }
            }

            //Sıralama işlemini Array sınıfı kullanılarak da yapılabilir.

            Array.Sort(GelenSayilar);


       
            //belirlenen 10 rakamı textboxlara yazdırıyorum.
            textBox1.Text = GelenSayilar[0].ToString();
            textBox2.Text = GelenSayilar[1].ToString();
            textBox3.Text = GelenSayilar[2].ToString();
            textBox4.Text = GelenSayilar[3].ToString();
            textBox5.Text = GelenSayilar[4].ToString();
            textBox6.Text = GelenSayilar[5].ToString();
            textBox7.Text = GelenSayilar[6].ToString();
            textBox8.Text = GelenSayilar[7].ToString();
            textBox9.Text = GelenSayilar[8].ToString();
            textBox10.Text = GelenSayilar[9].ToString();


            //her butona başladığında yeni 10 lu listeyi listebox kontrolünün ilk sırarısına 
            //yerleştirmek için listbox ın insert metodunu kullanıyorum

            string liste = GelenSayilar[0].ToString();
            
            for (int i = 1; i < 10; i++)
			{
                liste += " - " + GelenSayilar[i].ToString();
			}

            listBox1.Items.Insert(0,liste);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //formun başlarken formun başlığını değiştirmek istiyorum . Başlık On numara oyunu olsun
            //bunun için this anahtar sözcüğünü kullanarak Text değerini değiştriyorum.

            this.Text = "ON NUMARA OYUNU";
        }
    }
}