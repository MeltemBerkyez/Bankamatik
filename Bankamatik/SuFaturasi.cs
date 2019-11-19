using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankamatik
{
    public partial class SuFaturasi : Form
    {
        BusinessLogicLayer BLL;
        public string TC;
        public SuFaturasi()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Musteri M;
            M = BLL.Musteri_KayitGetir(TC);

            double islem = float.Parse(M.Bakiye) - float.Parse(textBox1.Text);
            if (islem < 0)
            {
                MessageBox.Show("Hesabnızdaki limit kadar çekim yapabilirsiniz..");
            }
            else
            {
                int result = BLL.Para_Cekim(TC, islem);
                if (result == -1)
                {
                    MessageBox.Show("Beklenmedik Hata Oluştu..");
                }
                else
                {
                    MessageBox.Show("Faturanız Ödendi..");
                    ANASAYFA ana = new ANASAYFA();
                    ana.TC = TC;
                    ana.Show();
                    this.Hide();
                }
            }
        }
    }
}
