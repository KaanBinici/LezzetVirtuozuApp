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

namespace LezzetVirtuozuApp.UIFORM.Formlar
{
    public partial class FormVucutYagOrani : Form
    {
        IMemberDetailSERVICE _memberDetailSERVICE = new MemberDetailSERVICE();
        public FormVucutYagOrani()
        {
            InitializeComponent();
            rdb_erkek.Checked = true;
            lbl_oranSonucu.Visible = false;
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            bool gender = rdb_erkek.Checked ? true : false;

            double oran = Fonksiyonlar.FatRatioCalculate(gender, txt_boy.Text, txt_boyun.Text, txt_bel.Text, txt_kalca.Text);
            txt_yagOrani.Text = oran.ToString();
            lbl_oranSonucu.Visible = true;

            ShowRatioInLabel(oran, gender);

            var result= _memberDetailSERVICE.GetMemberById(FormUyeBilgileri.online)




            Fonksiyonlar.Clean(this.Controls);
        }
        public void ShowRatioInLabel(double oran, bool gender)
        {
            if (gender == true && oran > 22)
            {
                lbl_oranSonucu.ForeColor = Color.Red;
                lbl_oranSonucu.Text = "Yağ oranınız olması gerekenden fazla.";
            }
            else if (gender == true && oran < 22 && oran > 17)
            {
                lbl_oranSonucu.ForeColor = Color.Green;
                lbl_oranSonucu.Text = "Yağ oranınız ideal durumda.";
            }
            else if (gender == true && oran < 17)
            {
                lbl_oranSonucu.ForeColor = Color.Blue;
                lbl_oranSonucu.Text = "Yağ oranınız olması gerekenden az.";
            }
            else if (gender == false && oran > 26)
            {
                lbl_oranSonucu.ForeColor = Color.Red;
                lbl_oranSonucu.Text = "Yağ oranınız olması gerekenden fazla.";
            }
            else if (gender == false && oran < 26 && oran > 21)
            {
                lbl_oranSonucu.ForeColor = Color.Green;
                lbl_oranSonucu.Text = "Yağ oranınız ideal durumda.";
            }
            else if (gender == false && oran < 21)
            {
                lbl_oranSonucu.ForeColor = Color.Blue;
                lbl_oranSonucu.Text = "Yağ oranınız olması gerekenden az.";
            }
        }
    }
}
// fotoğraf eklenecek-- member detail e update olacak yağ oranı