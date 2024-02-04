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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace LezzetVirtuozuApp.UIFORM.Formlar
{
    public partial class FormVucutKitleIndeksi : Form
    {
        IMemberDetailSERVICE _memberDetailSERVICE;
        private MemberDetail _memberDetail;
        public FormVucutKitleIndeksi(MemberDetail memberDetail)
        {
            
            InitializeComponent();
            _memberDetail = memberDetail;
            _memberDetailSERVICE = new MemberDetailSERVICE();
            if (_memberDetail.Height != null)
                txt_boyKitle.Text = _memberDetail.Height.ToString();
            if (_memberDetail.Weight != null)
                txt_kiloKitle.Text = _memberDetail.Weight.ToString();

            lbl_durum.Visible = false;
        }
        public FormVucutKitleIndeksi()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            try
            {
                double kilo, boy;
                kilo = Convert.ToDouble(txt_kiloKitle.Text);
                boy = Convert.ToDouble(txt_boyKitle.Text) / 100;
                double sonuc = (kilo / (boy * boy));
                txt_vucutEndeksi.Text = Math.Round(sonuc, 2).ToString();
                lbl_durum.Visible = true;

                if (sonuc < 18.5)
                {
                    lbl_durum.Text = "Zayıf";
                    lbl_durum.ForeColor = Color.DarkOrange;
                    lbl_durum.ForeColor = Color.DarkOrange;
                }
                else if (sonuc > 18.5 && sonuc < 25)
                {
                    lbl_durum.Text = "Normal";
                    lbl_durum.ForeColor = Color.DarkBlue;
                    lbl_durum.ForeColor = Color.DarkBlue;
                }
                else if (sonuc > 25 && sonuc < 30)
                {
                    lbl_durum.Text = "Fazla Kilolu";
                    lbl_durum.ForeColor = Color.DarkGreen;
                    lbl_durum.ForeColor = Color.DarkGreen;
                }
                else if (sonuc > 30 && sonuc < 40)
                {
                    lbl_durum.Text = "Obez";
                    lbl_durum.ForeColor = Color.DarkRed;
                    lbl_durum.ForeColor = Color.DarkRed;
                }
                else if (sonuc > 40)
                {
                    lbl_durum.Text = "Aşırı Obez";
                    lbl_durum.ForeColor = Color.Brown;
                    lbl_durum.ForeColor = Color.Brown;
                }
                _memberDetail.BodyMassIndex = sonuc;
                _memberDetailSERVICE.Update(_memberDetail);
                MessageBox.Show("Vücut Kitle Endeksiniz Hesaplandı.");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen verileri tam ve doğru formatta giriniz.");
            }
        }
    }
}

