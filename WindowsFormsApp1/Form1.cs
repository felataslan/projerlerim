﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dunya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "felat";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "felat";
            label6.Text = "aslan";
            label8.Text = "yazılım mühendisi";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = textBox1.Text;
            label6.Text = textBox2.Text;
            label8.Text = textBox3.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
