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
    public partial class Form1 : Form
    {
        BusinessLogicLayer BLL;
        public Form1()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = BLL.Kullanici_Giris(textBox1.Text, textBox2.Text);
            if (result>0)
            {
                ANASAYFA ana = new ANASAYFA();
                ana.TC = textBox1.Text;
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Hatalı.");
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl kayitOl = new KayitOl();
            kayitOl.Show();
        }
    }
}
