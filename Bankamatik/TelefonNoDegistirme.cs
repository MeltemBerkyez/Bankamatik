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
    public partial class TelefonNoDegistirme : Form
    {
        BusinessLogicLayer BLL;
        public string TC;
        public TelefonNoDegistirme()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (!string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                
                    BLL.TELEFON_Guncelle(TC, maskedTextBox1.Text);
                    MessageBox.Show("Telefon Numaranız Guncellendi..");

            }
            else
            {
                MessageBox.Show("LUTFEN ALANI DOLDURUN");
            }
        }

        private void TelefonNoDegistirme_Load(object sender, EventArgs e)
        {

        }
    }
}
