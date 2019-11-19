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
    public partial class SifreDegistirme : Form
    {
        BusinessLogicLayer BLL;
        public string TC;
        public SifreDegistirme()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer(); 
        }

        private void SifreDegistirme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri M;
            M = BLL.Musteri_KayitGetir(TC);
            if (M.Sifre==textBox1.Text)
            {
                if (textBox2.Text==textBox3.Text)
                {
                    BLL.Sifre_Guncelle(TC, textBox2.Text);
                    MessageBox.Show("Şifreniz Guncellendi..");

                }
                else
                {
                    MessageBox.Show("Girdiğiniz Yeni Şifre İle Şifre Tekrar Aynı Deği ");
                }
            }
            else
            {
                MessageBox.Show("Eski Şifreniz Uyuşmuyor.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
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
