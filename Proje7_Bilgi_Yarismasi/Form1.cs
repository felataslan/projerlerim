using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje7_Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int SoruNo = 0, Dogru = 0, Yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnB.Text;
            if (label5.Text == label4.Text)
            {
               
                Dogru++;
                Lbldogru.Text = Dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                
                Yanlis++;
                Lblyanlis.Text = Yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnC.Text;
            if (label5.Text == label4.Text)
            {
                
                Dogru++;
                Lbldogru.Text = Dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                
                Yanlis++;
                Lblyanlis.Text = Yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnD.Text;
            if (label5.Text == label4.Text)
            {
               
                Dogru++;
                Lbldogru.Text = Dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
               
                Yanlis++;
                Lblyanlis.Text = Yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled =false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnA.Text;
            if (label5.Text == label4.Text)
            {
              
                Dogru++;
                Lbldogru.Text = Dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                
                Yanlis++;
                Lblyanlis.Text = Yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;
            SoruNo++;
            LblSoru.Text = SoruNo.ToString();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            if (SoruNo == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında kuruldu?";
                BtnA.Text = "1920";
                BtnB.Text = "1923";
                BtnC.Text = "1919";
                BtnD.Text = "1917";
                label4.Text = "1923";
            }
            else if (SoruNo == 2)
            {
                richTextBox1.Text = "Galatasarayın hangi yılı aşağıdakşlerden hangisidir?";
                BtnA.Text = "1907";
                BtnB.Text = "1903";
                BtnC.Text = "1905";
                BtnD.Text = "1963";
                label4.Text = "1905";

            }
            else if (SoruNo==3)
            {
                richTextBox1.Text = "cumhuriyet bayramı ne zamandır";
                BtnA.Text = "10 Kasım";
                BtnB.Text = "19 Mayıs";
                BtnC.Text = "29 Ekim";
                BtnD.Text = "23 Nisan";
                label4.Text = "29 Ekim";
                
            }
            else
            {
                MessageBox.Show("YARIŞMA SONUCU " +"\n"+"Doğru: "+ Dogru +"\n"+"Yanlış: "+Yanlis);
                SoruNo = 3;
                LblSoru.Text = SoruNo.ToString();
                BtnSonraki.Text = "Sonuclar";
            }
        }

        
    }
}
