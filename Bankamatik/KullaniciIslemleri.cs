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
  
    public partial class KullaniciIslemleri : Form
    {
        public string TC;
        
        public KullaniciIslemleri()
        {
            InitializeComponent();
          
        }

        private void KullaniciIslemleri_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SifreDegistirme sifreDegistirme = new SifreDegistirme();
            sifreDegistirme.TC = TC;
            sifreDegistirme.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelefonNoDegistirme telefonNoDegistirme = new TelefonNoDegistirme();
            telefonNoDegistirme.TC = TC;
            telefonNoDegistirme.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MailDegistirme mailDegistirme = new MailDegistirme();
            mailDegistirme.TC = TC;
            mailDegistirme.Show();
        }
    }
}
