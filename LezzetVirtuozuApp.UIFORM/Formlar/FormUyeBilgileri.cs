using DiyetUygulama.DATA.Entities;
using DiyetUygulama.DATA.Enums;
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
    public partial class FormUyeBilgileri : Form
    {
        IMemberSERVICE _memberSERVICE;
        IMemberDetailSERVICE _memberDetailSERVICE;

        private Member _member;
        private MemberDetail _memberDetail;
        public FormUyeBilgileri(Member member, MemberDetail memberDetail)
        {
            InitializeComponent();
            _memberDetailSERVICE = new MemberDetailSERVICE();
            _memberSERVICE = new MemberSERVICE();
            _member = member;
            _memberDetail = memberDetail;
        }
        public FormUyeBilgileri()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                _member.MemberName = txt_ad.Text;
                _member.MemberSurname = txt_soyad.Text;

                _memberDetail.Height = Convert.ToInt32(txt_boy.Text);
                _memberDetail.Weight = Convert.ToInt32(txt_kilo.Text);
                _memberDetail.Gender = rdb_erkek.Checked ? true : false;
                _memberDetail.Height = Convert.ToInt32(txt_boy.Text);
                _memberDetail.Allergy1 = cmb_alerji1.SelectedIndex != -1 ? (Allergies)cmb_alerji1.SelectedValue : Allergies.NoAllergy;
                _memberDetail.Allergy2 = cmb_alerji2.SelectedIndex != -1 ? (Allergies)cmb_alerji2.SelectedValue : Allergies.NoAllergy;
                _memberDetail.BirthDate = dtp_dogumGunu.Value;
                _memberDetail.IsDiabetes = chk_diyabetMi.Checked ? true : false;

                _memberSERVICE.Update(_member);
                _memberDetailSERVICE.Update(_memberDetail);

                MessageBox.Show("Bilgileriniz Kaydedildi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bilgilerinizi eksiksiz giriniz.");
            }
        }

        private void FormUyeBilgileri_Load(object sender, EventArgs e)
        {

            cmb_alerji1.DataSource = Enum.GetValues(typeof(Allergies));
            cmb_alerji2.DataSource = Enum.GetValues(typeof(Allergies));
            FillInformation();
        }

        private void btn_resimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PhotoPath(png,jpg,gif,jpeg,JPG)|*.png;*.jpg;*.gif;*.jpeg;*.JPG";
            DialogResult result = ofd.ShowDialog();
            try
            {
                if (result == DialogResult.OK)
                {
                    pb_resimUye.Image = Image.FromFile(ofd.FileName);
                    pb_resimUye.Tag = Path.GetExtension(ofd.FileName);

                    _member.PhotoPath = pb_resimUye.Tag.ToString();
                    pb_resimUye.Image.Save(Application.StartupPath + "MemberPictures/" + _member.PhotoPath);
                    _memberSERVICE.Update(_member);

                    MessageBox.Show("Fotoğrafınız başarıyla kaydedildi.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Doğru Formatta Resim Ekleyiniz.(png,jpg,gif,jpeg,JPG)");
            }
            
        }
        private void FillInformation()
        {
            txt_ad.Text = _member.MemberName;
            txt_soyad.Text = _member.MemberSurname;
            txt_kilo.Text = _memberDetail.Weight.ToString();
            txt_boy.Text = _memberDetail.Height.ToString();
            txt_suTuketimi.Text = Math.Round((double)_memberDetail.WaterConsumptionNeeded, 2).ToString();
            txt_yagOrani.Text = Math.Round((double)_memberDetail.FatRatio, 2).ToString();
            rdb_erkek.Checked = _memberDetail.Gender == true ? true : false;
            chk_diyabetMi.Checked = _memberDetail.IsDiabetes == true ? true : false;
            dtp_dogumGunu.Value = _memberDetail.BirthDate.Value;
            cmb_alerji1.Text = _memberDetail.Allergy1.ToString();
            cmb_alerji2.Text = _memberDetail.Allergy2.ToString();
            txt_kitleEndeksi.Text = Math.Round((double)_memberDetail.BodyMassIndex, 2).ToString(); 

            if (!string.IsNullOrEmpty(_member.PhotoPath))
            {
                pb_resimUye.Image = Image.FromFile("MemberPictures/" + _member.PhotoPath);
            }
        }
    }
}
