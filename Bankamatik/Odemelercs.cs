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
    public partial class Odemelercs : Form
    {
        public string TC;
        public Odemelercs()
        {
            InitializeComponent();
        }

        private void Odemelercs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ElektrikFaturasi elektrik = new ElektrikFaturasi();
            elektrik.TC = TC;
            elektrik.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelefonFaturasi telefon = new TelefonFaturasi();
            telefon.TC = TC;
            telefon.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InternetFaturasi internet = new InternetFaturasi();
            internet.TC = TC;
            internet.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SuFaturasi suFaturasi = new SuFaturasi();
            suFaturasi.TC = TC;
            suFaturasi.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OGSOdemeleri ogsOdemeleri = new OGSOdemeleri();
            ogsOdemeleri.TC = TC;
            ogsOdemeleri.Show();
            this.Hide();
        }
    }
}
