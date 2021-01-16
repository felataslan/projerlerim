using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje6_IfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitap;
            double tutar;
            kitap = Convert.ToInt16(kitapAdedi.Text);
            tutar = kitap * 8;
            if(kitap>0 && kitap <= 20)
            {
                tutar = tutar * 0.8;
                Fatura.Text = Convert.ToString(tutar+" TL");
            }
            else if(kitap>20 && kitap <= 40)
            {
                tutar = tutar * 0.6;
                Fatura.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar * 0.5;
                Fatura.Text = Convert.ToString(tutar);
            }
        }
    }
}
