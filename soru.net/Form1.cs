using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int dogru, yanlis;
            double netDogru;

            dogru = Convert.ToInt32(cmbDogru.Text);
            yanlis = Convert.ToInt32(cmbYanlis.Text);

            netDogru = dogru - yanlis / 4.0;

            lblNet.Text = "Net Doğru Sayısı: " + netDogru.ToString();


        }
    }
}
