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
    public partial class ParaCekme : Form
    {
        BusinessLogicLayer BLL;
        public string TC;
        public ParaCekme()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer();
        }

        private void ParaCekme_Load(object sender, EventArgs e)
        {
            
            Musteri M;
            M = BLL.Musteri_KayitGetir(TC);
            label2.Text = M.Bakiye;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double islem = float.Parse(label2.Text) - float.Parse(textBox1.Text);
            if (islem<0)
            {
                MessageBox.Show("Hesabnızdaki limit kadar çekim yapabilirsiniz..");
            }
            else
            {
                int result = BLL.Para_Cekim(TC, islem);
                if (result==-1)
                {
                    MessageBox.Show("Beklenmedik Hata Oluştu..");
                }
                else
                {
                    MessageBox.Show("Paranızı Alabilirsiniz....");
                    ANASAYFA ana = new ANASAYFA();
                    ana.TC = TC;
                    ana.Show();
                    this.Hide();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ANASAYFA ana = new ANASAYFA();
            ana.TC = TC;
            ana.Show();
            this.Hide();
        }
    }
}
