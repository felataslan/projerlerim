using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay,bilet, toplam;
            
            misir = Convert.ToInt16(txtMisir.Text);
            su = Convert.ToInt16(txtSu.Text);
            cay = Convert.ToInt16(txtCay.Text);
            bilet = Convert.ToInt16(txtBilet.Text);
            toplam = misir * 4 + su * 1 + cay * 2 + bilet*8;
            lblToplam.Text = toplam.ToString() + " TL";

            kasatutar = kasatutar + toplam;
            lblKasa.Text = kasatutar.ToString() + " TL";
            if (txtMisir.Text =="")
            {
                misir
            }
            else if (txtSu.Text =="")
            {
               su = Convert.ToInt16("0");
            }
            else if (txtCay.Text =="")
            {
               cay = Convert.ToInt16("0");
            }
            else if (txtBilet.Text =="")
            {
                bilet = Convert.ToInt16("0");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMisir.Text ="" ;
            txtSu.Text = "";
            txtCay.Text = "";
            txtBilet.Text = "";
            lblToplam.Text = "00 TL";
            txtMisir.Focus();

        }
    }
}
