using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degişkenler1_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("ÖĞRENCİ NOTLARI");
            listBox1.Items.Add("Ad: "+ textBox1.Text);
            listBox1.Items.Add("Soyad: " +textBox2.Text);
            listBox1.Items.Add("1.sınav notu: " + textBox3.Text);
            listBox1.Items.Add("2.sınav notu: " + textBox4.Text);
            listBox1.Items.Add("3.sınav notu: " + textBox5.Text);
            double sinav1, sinav2, sinav3;
            double ort;
            sinav1 = Convert.ToDouble(textBox3.Text);
            sinav2 = Convert.ToDouble(textBox4.Text);
            sinav3 = Convert.ToDouble(textBox5.Text);
            ort = (sinav1 + sinav2 + sinav3) / 3;
            listBox1.Items.Add("Sınav Ortalaması:" +ort);

















            //double sayi;
            //sayi = Convert.ToDouble(textBox1.Text);
            //label2.Text = sayi.ToString();









            //int kenar, alan, cevre;
            //kenar = 10;
            //alan =kenar * kenar;
            //cevre = kenar * 4;
            //label1.Text = "alan: " + alan+ " cevre: "+ cevre;




            //int sayi1,sayi2,toplam;
            //sayi1 = 4;
            //sayi2 = 5;
            //toplam = sayi1 + sayi2;

            //label1.Text = toplam.ToString();



            //string metin;
            //metin = textBox1.Text;
            //label1.Text = metin;
        }
    }
}
