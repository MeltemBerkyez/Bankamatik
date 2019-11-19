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
    public partial class KayitOl : Form
    {
        BusinessLogicLayer BLL;
        public KayitOl()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KayitOl_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (txtSifre.Text == txtsifretekrar.Text)
            {



                bool ibanolustumakarar = true;
                bool hesapolusturmakarar = true;
                Random rastgele = new Random();

                string ibanolustur = "TR " + rastgele.Next(10, 90) + " " + rastgele.Next(1000, 9999) + " " + rastgele.Next(1000, 9999) + " " + rastgele.Next(1000, 9999) + " " + rastgele.Next(1000, 9999) + " " + rastgele.Next(1000, 9999) + " " + rastgele.Next(1000, 9999) + " " + rastgele.Next(10, 99);
                int sonuc = BLL.IBAN_ARA(ibanolustur);

                while (ibanolustumakarar)
                {
                    if (sonuc >= 1)
                    {
                        ibanolustur = "TR " + rastgele.Next(10, 90) + " " + rastgele.Next(1000, 9999) + " " + rastgele.Next(1000, 9999) + " " + rastgele.Next(1000, 9999) + " " + rastgele.Next(1000, 9999) + " " + rastgele.Next(1000, 9999) + " " + rastgele.Next(1000, 9999) + " " + rastgele.Next(10, 99);
                    }
                    else
                    {
                        ibanolustumakarar = false;
                    }
                }

                string hesapno = rastgele.Next(100000, 999999).ToString() + rastgele.Next(10000, 99999).ToString();
                int sonuc2 = BLL.HESAP_ARA(hesapno);
                while (hesapolusturmakarar)
                {
                    if (sonuc2 >= 1)
                    {
                        hesapno = "TR " + rastgele.Next(10, 90) + " " + rastgele.Next(1000, 9999) + " " + rastgele.Next(1000, 9999) + " " + rastgele.Next(1000, 9999) + " " + rastgele.Next(1000, 9999) + " " + rastgele.Next(1000, 9999) + " " + rastgele.Next(1000, 9999) + " " + rastgele.Next(10, 99);
                    }
                    else
                    {
                        hesapolusturmakarar = false;
                    }
                }

                int ekle = BLL.Musteri_Ekle(txtTC.Text.Trim(), txtIsim.Text, txtSoyisim.Text, txttelefon.Text.Trim(), txtmail.Text, txtadres.Text, txtSifre.Text, 500, hesapno, ibanolustur);
                if (ekle > 0)
                {
                    MessageBox.Show("Eklendi");

                }
                else
                {
                    MessageBox.Show("Hata.");
                }

            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor");
            }


        }
    }
}
