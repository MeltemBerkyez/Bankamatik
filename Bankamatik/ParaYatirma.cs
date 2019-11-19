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
    public partial class ParaYatirma : Form
    {
        BusinessLogicLayer BLL;
        public string TC;
        public ParaYatirma()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ANASAYFA ana = new ANASAYFA();
            ana.TC = TC;
            ana.Show();
            this.Hide();
        }

        private void ParaYatirma_Load(object sender, EventArgs e)
        {
            Musteri M;
            M = BLL.Musteri_KayitGetir(TC);
            label2.Text = M.Bakiye;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double islem = float.Parse(label2.Text) + float.Parse(textBox1.Text);

            if (float.Parse(textBox1.Text) < 0)
            {
                MessageBox.Show("Yanlış Tutar Girdiniz");
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
                    MessageBox.Show("Paranızı Yatırıldı....");
                    ANASAYFA ana = new ANASAYFA();
                    ana.TC = TC;
                    ana.Show();
                    this.Hide();
                }
            }
        }
    }
}
