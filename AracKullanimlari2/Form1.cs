using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKullanimlari2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Bursa");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("kasiyer");
            listBox1.Items.Add("futbolcu");
            listBox1.Items.Add("muhasebeci");
            listBox1.Items.Add("antrenör");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text +" "+textBox3.Text+" "+textBox4.Text+" "+textBox5.Text+" "+textBox6.Text);
        }
    }
}
