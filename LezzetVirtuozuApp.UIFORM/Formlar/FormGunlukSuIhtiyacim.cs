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

namespace LezzetVirtuozuApp.UIFORM.Formlar
{
    public partial class FormGunlukSuIhtiyacim : Form
    {
        IMemberDetailSERVICE _memberDetailSERVICE;
        private MemberDetail _memberDetail;
        public FormGunlukSuIhtiyacim(MemberDetail memberDetail)
        {
            InitializeComponent();
            _memberDetailSERVICE = new MemberDetailSERVICE();
            _memberDetail = memberDetail;
            pb_resimSu.Image = System.Drawing.Image.FromFile("Pictures\\meyveiçensudamlası.jpg");
        }

        public FormGunlukSuIhtiyacim()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            if (_memberDetail.Weight != null)
            {
                double weight = (double)_memberDetail.Weight;
                txt_kilo.Text = weight.ToString();
                txt_suIhtiyaci.Text = Math.Round(Fonksiyonlar.WaterConsumptionCalculate(weight), 2).ToString();
                _memberDetail.WaterConsumptionNeeded = Convert.ToDouble(txt_suIhtiyaci.Text);
                _memberDetailSERVICE.Update(_memberDetail);

                MessageBox.Show("Günlük Su İhtiyacınız Hesaplandı.");
            }
        }
    }
}
