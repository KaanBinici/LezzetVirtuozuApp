using DiyetUygulama.DATA.Entities;
using DiyetUygulama.DATA.Enums;
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

namespace LezzetVirtuozuApp.UIFORM.Formlar
{
    public partial class FormUyeBilgileri : Form
    {
        IMemberSERVICE _memberSERVICE = new MemberSERVICE();
        IMemberDetailSERVICE _memberDetailSERVICE = new MemberDetailSERVICE();
        private Member _member;
        private MemberDetail _memberDetail;
        public FormUyeBilgileri(Member member, MemberDetail memberDetail)
        {
            _member = member;
            _memberDetail = memberDetail;
        }
        public FormUyeBilgileri()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            var onlineMember = _memberSERVICE.GetMemberByEmail(UyeGirisi.onlineMember);
            var onlineMemberDetail = _memberDetailSERVICE.GetMemberById(onlineMember.MemberId);
            onlineMember.MemberName = txt_ad.Text;
            onlineMember.MemberSurname = txt_soyad.Text;
            onlineMemberDetail.Height = Convert.ToInt32(txt_boy.Text);
            onlineMemberDetail.Weight = Convert.ToInt32(txt_kilo.Text);
            onlineMemberDetail.Gender = rdb_erkek.Checked ? true : false;
            onlineMemberDetail.Height = Convert.ToInt32(txt_boy.Text);
            onlineMemberDetail.Allergy1 = cmb_alerji1.SelectedIndex != -1 ? (Allergies)cmb_alerji1.SelectedValue : Allergies.NoAllergy;
            onlineMemberDetail.Allergy2 = cmb_alerji2.SelectedIndex != -1 ? (Allergies)cmb_alerji2.SelectedValue : Allergies.NoAllergy;
            onlineMemberDetail.BirthDate = dtp_dogumGunu.Value;
            onlineMemberDetail.IsDiabetes = chk_diyabetMi.Checked ? true : false;

            _memberSERVICE.Update(onlineMember);
            _memberDetailSERVICE.Update(onlineMemberDetail);

            MessageBox.Show("Bilgileriniz Kaydedildi.");
        }

        private void FormUyeBilgileri_Load(object sender, EventArgs e)
        {
            cmb_alerji1.DataSource = Enum.GetValues(typeof(Allergies));
            cmb_alerji2.DataSource = Enum.GetValues(typeof(Allergies));
        }
    }
}
