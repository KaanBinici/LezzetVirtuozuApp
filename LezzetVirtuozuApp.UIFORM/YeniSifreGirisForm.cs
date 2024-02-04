using DiyetUygulama.SERVICE.Concrete;
using DiyetUygulama.SERVICE.Interfaces;
using LezzetVirtuozuApp.UIFORM.Metotlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace LezzetVirtuozuApp.UIFORM
{
    public partial class YeniSifreGirisForm : Form
    {
        IMemberSERVICE _memberSERVICE = new MemberSERVICE();
        public YeniSifreGirisForm()
        {
            InitializeComponent();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbKilitFoto_Click(object sender, EventArgs e)
        {
            if (txtsifreTekrar.UseSystemPasswordChar == true)
                txtsifreTekrar.UseSystemPasswordChar = false;
            else
                txtsifreTekrar.UseSystemPasswordChar = true;
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            if (txtsifreTekrar.Text == txtsifre.Text)
            {
                var result = _memberSERVICE.GetMemberByEmail(SifreUnuttunForm.ePosta);
                result.Password = txtsifreTekrar.Text;
                _memberSERVICE.Update(result);
                MessageBox.Show("Şifreniz Başarıyla Güncellendi.");

                this.Close();
                UyeGirisi frmUyeGiris = new UyeGirisi();
                frmUyeGiris.Show();
            }
            else
            {
                MessageBox.Show("Girilen şifreler aynı değil.");
            }
        }

        private void txtsifre_TextChanged(object sender, EventArgs e)
        {
            lbl_sifreGucu.Text = Fonksiyonlar.PasswordLevel(txtsifre.Text);
            if (Fonksiyonlar.PasswordLevel(txtsifre.Text) == "Yüksek")
            {
                lbl_sifreGucu.ForeColor = Color.Green;
            }
            else if (Fonksiyonlar.PasswordLevel(txtsifre.Text) == "Orta")
            {
                lbl_sifreGucu.ForeColor = Color.Orange;
            }
            else if (Fonksiyonlar.PasswordLevel(txtsifre.Text) == "Düşük")
            {
                lbl_sifreGucu.ForeColor = Color.Red;
            }
        }

        private void pb_kilitFoto_Click(object sender, EventArgs e)
        {
            if (txtsifre.UseSystemPasswordChar == true)
                txtsifre.UseSystemPasswordChar = false;
            else
                txtsifre.UseSystemPasswordChar = true;
        }
    }
}
