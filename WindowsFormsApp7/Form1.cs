using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int kup(int sayi)
        {
           int sonuc = sayi * sayi * sayi;

            return sonuc;
        }
        //int carpım(int s1, int s2, int s3)
        //{
        //    int s4 = s1 *s2*s3;
        //    return s4;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt16(textBox1.Text);
            label1.Text = kup(s).ToString();


            //label1.Text = carpım(2, 4,3).ToString();
            //label2.Text = carpım(3, 5,3).ToString();
            //label3.Text = carpım(5, 8,3).ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Geri Dönülmeyen Metotlar

        //void kisiselBilgiler()
        //{
        //    textBox1.Text = "felat";
        //    textBox2.Text = "aslan";
        //    textBox3.Text = "software enginner";
        //    textBox4.Text = "21";
        //}
        //void renklendir()
        //{
        //    textBox1.BackColor = Color.Gold;
        //    textBox2.BackColor = Color.Green;
        //    textBox3.BackColor = Color.Blue;
        //    textBox4.BackColor = Color.LightBlue;
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    kisiselBilgiler();
        //    renklendir();
        //}
    }
}
