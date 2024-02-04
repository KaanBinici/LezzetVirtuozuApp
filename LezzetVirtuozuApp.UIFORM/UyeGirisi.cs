
using DiyetUygulama.DAL.Contexts;
using DiyetUygulama.DATA.Entities;
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

namespace LezzetVirtuozuApp.UIFORM
{
    public partial class UyeGirisi : Form
    {
        IMemberSERVICE _memberSERVICE = new MemberSERVICE();
        IMemberDetailSERVICE _memberDetailSERVICE = new MemberDetailSERVICE();
        public UyeGirisi()
        {
            InitializeComponent();
            labelrenkvecizgi();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void labelrenkvecizgi()
        {
            lblUyeOl.MouseEnter += labelRenkveAltCizgi.Label_MouseEnter;
            lblUyeOl.MouseLeave += labelRenkveAltCizgi.Label_MouseLeave;
            lblSifreUnuttun.MouseEnter += labelRenkveAltCizgi.Label_MouseEnter;
            lblSifreUnuttun.MouseLeave += labelRenkveAltCizgi.Label_MouseLeave;
            lblAdminGirisi.MouseEnter += labelRenkveAltCizgi.Label_MouseEnter;
            lblAdminGirisi.MouseLeave += labelRenkveAltCizgi.Label_MouseLeave;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            

            try
            {
                var result = _memberSERVICE.GetWhere(x => x.Email == txtEposta.Text & x.Password == txtSifre.Text).Count();
                if (result != 0)
                {
                    var onlineMember = _memberSERVICE.GetMemberByEmail(txtEposta.Text);
                    var onlineMemberDetail = _memberDetailSERVICE.GetMemberById(onlineMember.MemberId);
                    AnaMenu anaMenuForm = new AnaMenu(onlineMember, onlineMemberDetail);
                    anaMenuForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı E-Posta veya Şifre.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void pbKilitFoto_Click(object sender, EventArgs e)
        {
            if (txtSifre.UseSystemPasswordChar == true)
                txtSifre.UseSystemPasswordChar = false;
            else
                txtSifre.UseSystemPasswordChar = true;
        }

        private void lblUyeOl_Click(object sender, EventArgs e)
        {
            UyeOlForm uyeOlForm = new UyeOlForm();
            uyeOlForm.Show();
            this.Hide();
        }

        private void lblAdminGirisi_Click(object sender, EventArgs e)
        {
            AdminGirisiForm adminForm = new AdminGirisiForm();
            adminForm.Show();
            this.Hide();
        }

        private void lblSifreUnuttun_Click(object sender, EventArgs e)
        {
            SifreUnuttunForm frmSifremiUnuttum = new SifreUnuttunForm();
            frmSifremiUnuttum.Show();
            this.Hide();
        }
    }
}
