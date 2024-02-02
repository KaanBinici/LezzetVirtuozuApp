using DiyetUygulama.DAL.Contexts;
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
    public partial class KodGirisForm : Form
    {
        IMemberSERVICE _memberSERVICE = new MemberSERVICE();
        public KodGirisForm()
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
            if (txtSifre.Text == UyeOlForm.onayKodu)
            {
                Member member = new Member();
                member.Email = UyeOlForm.ePosta;
                member.Password = UyeOlForm.sifre;
                member.MemberDetail = new MemberDetail();
                _memberSERVICE.Add(member);
                MessageBox.Show("Üyeliğiniz oluşturuldu.");

                this.Close();
                UyeGirisi frmUyeGirisi = new UyeGirisi();
                frmUyeGirisi.Show();
            }
            else
            {
                MessageBox.Show("Onay kodunuz yanlış.");
            }
        }
    }
}
