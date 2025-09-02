using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HesapMakinesi
{
    public partial class hesap_makinesi : Form
    {
        public hesap_makinesi()
        {
            InitializeComponent();
        }
        int isle1=0, isle2=0, isle3=0, isle4=0, isle5=0, isle6=0, isle7=0, isle8=0, isle9=0, isle10=0, isle11=0, isle12=0, isle13=0;

        private void bir_bolu_x_Click(object sender, EventArgs e)
        {
            double sonuc = 1 / Convert.ToDouble(label1.Text);
            label1.Text = sonuc.ToString();
        }

        private void logaritma_Click(object sender, EventArgs e)
        {
            double deger = Convert.ToInt32(label1.Text);
            double sonuc = Math.Log10(deger);
            label1.Text = sonuc.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        double eksilen;
        private void cıkarma_Click(object sender, EventArgs e)
        {
            eksilen=Convert.ToDouble(label1.Text);
            label1.Text = null;
            isle8 = 1;
        }

        private void kosunus_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(label1.Text);
            double sonuc1 = Math.Cos(sayi1 * (Math.PI / 180));
            label1.Text = sonuc1.ToString();
        }

        private void tanjant_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(label1.Text);
            double sonuc = Math.Tan(sayi);
            label1.Text = sonuc.ToString();
        }

        private void kare_Click(object sender, EventArgs e)
        {
            double karesi = Math.Pow(Convert.ToDouble(label1.Text),2);
            label1.Text = karesi.ToString();
        }
        double carpilan1;
        private void carpma_Click(object sender, EventArgs e)
        {
            carpilan1=Convert.ToDouble(label1.Text);
            label1.Text = null;
            isle11 = 1;
        }

        private void ln_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(label1.Text);
            int sonuc = Convert.ToInt32(Math.Log(x));
            label1.Text = sonuc.ToString();
        }
        double bolunen;
        private void bolme_Click(object sender, EventArgs e)
        {
            bolunen = Convert.ToDouble(label1.Text);
            label1.Text = null;
            isle13 = 1;
        }
        int us;

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = null;
            }
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = null;
            }
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = null;
            }
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = null;
            }
            label1.Text += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = null;
            }
            label1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = null;
            }
            label1.Text += "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = null;
            }
            label1.Text += "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = null;
            }
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = null;
            }
            label1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(label1.Text=="0")
            {
                label1.Text = null;
            }
            label1.Text+= "0";
        }

        private void hesap_makinesi_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            label1.Text += ".";
        }

        private void x_uzeri_y_Click(object sender, EventArgs e)
        {
            us =Convert.ToInt32(label1.Text);
            label1.Text = null;
            isle2 = 1;
        }

        void islem2()
        {
            double sonuc;
            double x = Convert.ToDouble(label1.Text);
            sonuc =Math.Pow(us,x);
            label1.Text = sonuc.ToString();
        }
        void islem3()
        {
        }
        void islem4()
        {
            double sonuc;
            double toplanan2=Convert.ToDouble(label1.Text);
            sonuc = toplanan1 + toplanan2;
            label1.Text = sonuc.ToString();
        }
        void islem8()
        {
            double sonuc;
            double eksilten=Convert.ToDouble(label1.Text);
            sonuc = eksilen-eksilten;
            label1.Text = sonuc.ToString();
        }
        void islem11()
        {
            double sonuc;
            double carpilan2=Convert.ToDouble(label1.Text);
            sonuc = carpilan1 * carpilan2;
            label1.Text = sonuc.ToString();
        }
        void islem13()
        {
            double sonuc;
            double bolen = Convert.ToDouble(label1.Text);
            if ((bolunen == 1) && (bolen == 0))
            {
                label1.Text = "hata";
            }
            else
            {
               sonuc = bolunen / bolen;
               label1.Text = sonuc.ToString();
            }
        }
        double toplanan1;
        private void button11_Click(object sender, EventArgs e)
        {
          toplanan1 = Convert.ToDouble(label1.Text);
          label1.Text = null;
          isle4 = 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(isle2==1)
            {
                islem2();
                isle2 = 0;
            }
            if (isle4==1)
            {
                islem4();
                isle4 = 0;
            }
            if (isle8==1)
            {
                islem8();
                isle2 = 0;
            }
            if (isle11==1)
            {
                islem11();
                isle11 = 0;
            }
            if(isle13==1)
            {
                islem13();
                isle13 = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToInt32(label1.Text);
            double sonuc1 = Math.Sin(sayi1 * (Math.PI / 180));
            label1.Text = sonuc1.ToString();
        }


        private void temizle_Click(object sender, EventArgs e)
        {
            label1.Text = null;
        }
    }
}
