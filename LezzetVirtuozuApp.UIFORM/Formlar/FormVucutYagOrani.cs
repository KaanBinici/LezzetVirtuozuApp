using DiyetUygulama.DATA.Entities;
using DiyetUygulama.SERVICE.Concrete;
using DiyetUygulama.SERVICE.Interfaces;
using LezzetVirtuozuApp.UIFORM.Metotlar;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LezzetVirtuozuApp.UIFORM.Formlar
{
    public partial class FormVucutYagOrani : Form
    {
        IMemberDetailSERVICE _memberDetailSERVICE;
        private MemberDetail _memberDetail;
        public FormVucutYagOrani(MemberDetail memberdetail)
        {
            InitializeComponent();
            _memberDetailSERVICE = new MemberDetailSERVICE();
            _memberDetail = memberdetail;

            if (_memberDetail.Height != null)
                txt_boy.Text = _memberDetail.Height.ToString();
            if (_memberDetail.Gender != null)
                rdb_erkek.Checked = _memberDetail.Gender == true ? true : false;

            lbl_oranSonucu.Visible = false;
        }
        public FormVucutYagOrani()
        {
            InitializeComponent();
            
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            try
            {
                bool gender = rdb_erkek.Checked ? true : false;

                double oran = Fonksiyonlar.FatRatioCalculate(gender, txt_boy.Text, txt_boyun.Text, txt_bel.Text, txt_kalca.Text);
                txt_yagOrani.Text = Math.Round(oran, 2).ToString();
                lbl_oranSonucu.Visible = true;

                ShowDetailsAboutRatio(oran, gender);

                _memberDetail.FatRatio = oran;
                _memberDetailSERVICE.Update(_memberDetail);

                MessageBox.Show("Vücut Yağ Oranınız Hesaplandı.");

                Fonksiyonlar.Clean(this.Controls);
            }
            catch (Exception)
            {
                MessageBox.Show("Verileri doğru ve eksiksiz giriniz.");
            }

        }
        public void ShowDetailsAboutRatio(double oran, bool gender)
        {
            if (gender == true && oran > 22)
            {
                lbl_oranSonucu.ForeColor = Color.Red;
                lbl_oranSonucu.Text = "Yağ oranınız olması gerekenden fazla.";
                pb_resim.Image = System.Drawing.Image.FromFile("Pictures\\fatman.jpg");
            }
            else if (gender == true && oran < 22 && oran > 17)
            {
                lbl_oranSonucu.ForeColor = Color.Green;
                lbl_oranSonucu.Text = "Yağ oranınız ideal durumda.";
                pb_resim.Image = System.Drawing.Image.FromFile("Pictures\\kaslıerkekfoto.jpg");
            }
            else if (gender == true && oran < 17)
            {
                lbl_oranSonucu.ForeColor = Color.Blue;
                lbl_oranSonucu.Text = "Yağ oranınız olması gerekenden az.";
                pb_resim.Image = System.Drawing.Image.FromFile("Pictures\\zayıfadam.jpg");
            }
            else if (gender == false && oran > 26)
            {
                lbl_oranSonucu.ForeColor = Color.Red;
                lbl_oranSonucu.Text = "Yağ oranınız olması gerekenden fazla.";
                pb_resim.Image = System.Drawing.Image.FromFile("Pictures\\fatgirl.jpg");
            }
            else if (gender == false && oran < 26 && oran > 21)
            {
                lbl_oranSonucu.ForeColor = Color.Green;
                lbl_oranSonucu.Text = "Yağ oranınız ideal durumda.";
                pb_resim.Image = System.Drawing.Image.FromFile("Pictures\\kaslıkadınfoto.jpg");
            }
            else if (gender == false && oran < 21)
            {
                lbl_oranSonucu.ForeColor = Color.Blue;
                lbl_oranSonucu.Text = "Yağ oranınız olması gerekenden az.";
                pb_resim.Image = System.Drawing.Image.FromFile("Pictures\\aşırızayıfkadın.jpg");
            }
        }
    }
}
// fotoğraf eklenecek-- member detail e update olacak yağ oranı