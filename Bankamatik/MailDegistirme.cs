using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankamatik
{
    public partial class MailDegistirme : Form
    {
        BusinessLogicLayer BLL;
        public string TC;
        public MailDegistirme()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (Regex.IsMatch(textBox1.Text, pattern))
                {
                    BLL.Mail_Guncelle(TC, textBox1.Text);
                    MessageBox.Show("Mail Adresiniz Guncellendi..");

                }
                else
                {
                    MessageBox.Show("Mail Adresi Tanımsız.");
                }
            }
            else
            {
                MessageBox.Show("LUTFEN ALANI DOLDURUN");
            }
        }
    }
}
