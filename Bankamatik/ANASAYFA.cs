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
    public partial class ANASAYFA : Form
    {
        BusinessLogicLayer BLL;
        public string TC;
        
        public ANASAYFA()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer();
           
        }

        private void ANASAYFA_Load(object sender, EventArgs e)
        {
            // BLL.Musteri_KayitGetir(TC);
            Musteri M;
            M = BLL.Musteri_KayitGetir(TC);
            label2.Text =M.Bakiye ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParaCekme paraCekme = new ParaCekme();
            paraCekme.TC = TC;
            paraCekme.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ParaTransferleri paraTransferleri = new ParaTransferleri();
            paraTransferleri.TC = TC;
            paraTransferleri.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParaYatirma parayatirma = new ParaYatirma();
            parayatirma.TC = TC;
            parayatirma.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();
            kullaniciIslemleri.TC = TC;
            kullaniciIslemleri.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Odemelercs odemeler = new Odemelercs();
            odemeler.TC = TC;
            odemeler.Show();
            this.Hide();
        }
    }
}
