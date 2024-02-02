using LezzetVirtuozuApp.UIFORM.Metotlar;
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
using DiyetUygulama.DAL.Contexts;

namespace LezzetVirtuozuApp.UIFORM
{
    public partial class UyeOlForm : Form
    {
        DiyetUygulamasiContext db;
        public UyeOlForm()
        {
            db = new DiyetUygulamasiContext();
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
        public static string onayKodu;
        public static string ePosta;
        public static string sifre;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            ePosta = txtEposta.Text;
            sifre = txtSifre.Text;

            var result = db.Members.Where(x => x.Email == ePosta).Count();
            if (result != 0)
            {
                MessageBox.Show("Bu mail sistemde kayıtlı.");
            }
            else
            {
                Random random = new Random();
                
                onayKodu = random.Next(100000, 999999).ToString();
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("LezzetVirtuozu@outlook.com", "LezzetVirtüözü");
                mail.To.Add(ePosta); 
                mail.Subject = "Lezzet Virtüözü Doğrulama Kodu"; 
                mail.IsBodyHtml = true;
                mail.Body = "Lezzet Virtüözü uygulamasına hoş geldin. İşte Doğrulama Kodun=" + onayKodu;
                                                                  
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Port = 587; 
                smtpClient.Host = "smtp.outlook.com"; 
                smtpClient.EnableSsl = true; 
                smtpClient.Credentials = new NetworkCredential("LezzetVirtuozu@outlook.com", "lezzet123");

                smtpClient.Send(mail); 
                smtpClient.Timeout = 100;

                KodGirisForm kodGirisForm = new KodGirisForm();
                kodGirisForm.Show();
            }
        }
    }
}

