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
    public partial class ParaTransferleri : Form
    {
        BusinessLogicLayer BLL;
        public string TC;
        public ParaTransferleri()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer();
        }
        float bakiye;
        private void ParaTransferleri_Load(object sender, EventArgs e)
        {
            Musteri M;
            M = BLL.Musteri_KayitGetir(TC);
            bakiye = float.Parse(M.Bakiye);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("TUTAR GİRİN");
                return;
            }

            float kalan = ((bakiye) - float.Parse(textBox1.Text));
            if (kalan<0)
            {
                MessageBox.Show("Limit Uygun Değil..");
            }
            else
            {
                if (maskedTextBox1.TextLength==33)
                {
                    int sonuc=BLL.IBAN_ARA(maskedTextBox1.Text);
                    if (sonuc>0)
                    {
                        int yatirmasonuc = BLL.IBAN_YATIR(maskedTextBox1.Text, float.Parse(textBox1.Text));
                        if (yatirmasonuc == -1)
                        {
                            MessageBox.Show("HATA");
                        }
                        else
                        {
                            MessageBox.Show("YATIRILDI...");
                            int result = BLL.Para_Cekim(TC, kalan);
                            ANASAYFA ANA = new ANASAYFA();
                            ANA.TC = TC;
                            ANA.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                       

                        MessageBox.Show("IBAN TANIMSIZ..");
                    }
                }
                else
                {
                    MessageBox.Show("IBAN GEÇERSİZ");
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_HesapTutar.Text))
            {
                MessageBox.Show("TUTAR GİRİN");
                return;
            }

            double kalan = ( (bakiye) - int.Parse(txt_HesapTutar.Text));

          
            if (kalan < 0)
            {
                MessageBox.Show("Limit Uygun Değil..");
            }
            else
            {
                if (txt_HesapNo.Text.Trim().Length ==11 )
                {
                    int sonuc = BLL.HESAP_ARA(txt_HesapNo.Text.Trim());
                    if (sonuc > 0)
                    {
                        int yatirmasonuc = BLL.HESAP_YATIR(txt_HesapNo.Text, int.Parse(txt_HesapTutar.Text));
                        if (yatirmasonuc == -1)
                        {
                            MessageBox.Show("HATA");
                        }
                        else
                        {
                            MessageBox.Show("YATIRILDI...");
                            int result = BLL.Para_Cekim(TC, kalan);
                            ANASAYFA ANA = new ANASAYFA();
                            ANA.TC = TC;
                            ANA.Show();
                            this.Hide();
                        }
                    }
                    else
                    {


                        MessageBox.Show("HESAP TANIMSIZ..");
                    }
                }
                else
                {
                    MessageBox.Show("HESAP GEÇERSİZ");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            IBANpnl.Visible = true;
            HESAPpnl.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            IBANpnl.Visible = false;
            HESAPpnl.Visible = true;
        }
    }
}
