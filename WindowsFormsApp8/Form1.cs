using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Const tlb = new Const(25);
            label1.Text = tlb.ToString();
            //Araba rb = new Araba();
            //rb.renk = "mavi";
            //rb.hız = 200;
            //rb.motor = 1650.86;
            //rb.fiyat = 55000;
            //rb.durum = 's';
            //rb.YIL = 2016;
            //rb.MARKA = "golf";
            //rb.plaka = "34 GS 1905";
            //rb.muayene = 2019;
            //rb.sahip = "ŞEFİK ASLAN";


            //label1.Text = rb.renk;
            //label2.Text = rb.hız.ToString();
            //label3.Text = rb.motor.ToString();
            //label4.Text = rb.fiyat.ToString();
            //label5.Text = rb.durum.ToString();
            //pictureBox1.BackColor = Color.Red;
            //label6.Text = rb.YIL.ToString();
            //label7.Text = rb.MARKA;
            //label8.Text = rb.plaka;
            //label9.Text = rb.muayene.ToString();
            //label10.Text = rb.sahip;
            

            Console.Read();
            

        }
    }
}
