using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARRAY_diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int  toplam = 0;
            int sayi = 0;
            int[] sınavlar = { 80, 60, 75, 90, 65,30,40,50,68,76};
            foreach (int x in sınavlar)
            {
                if (x%4==0)
                {
                    listBox1.Items.Add(x);
                    toplam = toplam + x;
                    sayi++;
                    
                }
                
            }
            label1.Text = toplam.ToString();
            label2.Text = sayi.ToString();
           


            //int[] sayilar = { 1, 2, 3, 4, 5, 6, 7 };
            //label1.Text = sayilar[3].ToString();

            //string[] kisiler = { "ali", "veli", "ayşe", "mehmet", "sinan", "aleyna" };
            //label1.Text = kisiler[3];

        }

       
    }
}
