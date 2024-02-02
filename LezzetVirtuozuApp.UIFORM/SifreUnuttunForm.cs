using DiyetUygulama.SERVICE.Concrete;
using DiyetUygulama.SERVICE.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LezzetVirtuozuApp.UIFORM
{
    public partial class SifreUnuttunForm : Form
    {
        IMemberSERVICE _memberSERVICE = new MemberSERVICE();
        public SifreUnuttunForm()
        {
            _memberSERVICE = new MemberSERVICE();
            InitializeComponent();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static string onayKodu;
        public static string ePosta;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            ePosta = txtEposta.Text;

            var result = _memberSERVICE.GetWhere(x => x.Email == ePosta).Count();

            if (result != 0)
            {
                Random random = new Random();

                onayKodu = random.Next(100000, 999999).ToString();
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("LezzetVirtuozu@outlook.com", "LezzetVirtüözü");
                mail.To.Add(ePosta); 
                mail.Subject = "Lezzet Virtüözü Doğrulama Kodu"; 
                mail.IsBodyHtml = true;
                mail.Body = "Lezzet Virtüözü uygulamasına hoş geldin. İşte Şifre Yenileme Kodunuz= " + onayKodu;

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Port = 587; 
                smtpClient.Host = "smtp.outlook.com"; 
                smtpClient.EnableSsl = true; 
                smtpClient.Credentials = new NetworkCredential("LezzetVirtuozu@outlook.com", "lezzet123");

                smtpClient.Send(mail); 
                smtpClient.Timeout = 100;
                

                SifreUnuttunKodGirisForm frmSifreKod = new SifreUnuttunKodGirisForm();
                frmSifreKod.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Girdiğiniz E-mail sistemde kayıtlı değil");
            }
        }
    }
}
