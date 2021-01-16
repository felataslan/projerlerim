using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(fotograf);
            listBox1.Items.Add(ad.Text);
            listBox1.Items.Add(soyad.Text);
            listBox1.Items.Add(yas.Text);
            listBox1.Items.Add(Cinsiyet);
            listBox1.Items.Add(not.Text);
            listBox1.Items.Add(telefon.Text);
            listBox1.Items.Add(YazılımDilleri);



        }
    }
}
