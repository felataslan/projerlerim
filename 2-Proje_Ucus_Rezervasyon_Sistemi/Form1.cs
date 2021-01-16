using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Proje_Ucus_Rezervasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("ROTA:  " + comboBox1.Text + " - "+comboBox2.Text);
            listBox1.Items.Add("Gidiş Tarihi: " + dateTimePicker1.Text);
            listBox1.Items.Add("Dönüş Tarihi: " + dateTimePicker2.Text);
            listBox1.Items.Add("Yolcu Ad-Soyad: " + maskedTextBox1.Text);
            listBox1.Items.Add("TC: " + maskedTextBox2.Text);
            listBox1.Items.Add("Telefon: " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kaydı Tamamlandı ");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var degistir=" ";
            degistir = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = degistir;
        }
    }
}
