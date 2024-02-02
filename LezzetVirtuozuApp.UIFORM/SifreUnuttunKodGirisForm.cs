using DiyetUygulama.DATA.Entities;
using DiyetUygulama.SERVICE.Concrete;
using DiyetUygulama.SERVICE.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LezzetVirtuozuApp.UIFORM
{
    public partial class SifreUnuttunKodGirisForm : Form
    {
        IMemberSERVICE _memberSERVICE = new MemberSERVICE();
        public SifreUnuttunKodGirisForm()
        {
            InitializeComponent();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbKilitFoto_Click(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = false;
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            
            if (txtSifre.Text == SifreUnuttunForm.onayKodu)
            {
                this.Close();
                YeniSifreGirisForm frmSifreGiris = new YeniSifreGirisForm();
                frmSifreGiris.Show();
            }
            else
            {
                MessageBox.Show("Şifre yenileme kodunuz yanlış.");
            }
        }
    }
}
