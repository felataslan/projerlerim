using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje3_Urun_Satisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double otv, kdv, UrunFiyati, SatisFiyati;
            
            UrunFiyati = Convert.ToDouble(fiyat.Text);
            otv = ( UrunFiyati / 100) * 8;
            kdv= (UrunFiyati / 100) * 18;
            SatisFiyati = otv + kdv + UrunFiyati;
            listBox1.Items.Add("Ürün Satış Fiyatı: ÖTV+KDV+ÜRÜN FİYATI: " + SatisFiyati);
        }
    }
}
