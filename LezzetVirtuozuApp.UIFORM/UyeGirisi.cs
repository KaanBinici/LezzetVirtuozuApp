
using DiyetUygulama.DAL.Contexts;
using DiyetUygulama.DATA.Entities;
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
        DiyetUygulamasiContext db;
        public static string onlineMember;
        public UyeGirisi()
        {
            db = new DiyetUygulamasiContext();
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
            var onlineMember = _memberSERVICE.GetMemberByEmail(UyeGirisi.onlineMember);
            var onlineMemberDetail = _memberDetailSERVICE.GetMemberById(onlineMember.MemberId);

            try
            {
                var result = db.Members.Where(x => x.Email == txtEposta.Text & x.Password == txtSifre.Text).Count();    //Metoto olacak
                if (result != 0)
                {
                    onlineMember = txtEposta.Text;
                    AnaMenu anaMenuForm = new AnaMenu();
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
            txtSifre.UseSystemPasswordChar = false;
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
