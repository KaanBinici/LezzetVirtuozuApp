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
    public partial class FormYiyecekveIcecek : Form
    {
        public FormYiyecekveIcecek()
        {
            InitializeComponent();
            LoadThema();
        }
        private void LoadThema()
        {
            foreach (Control Btns in this.Controls)
            {
                if (Btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)Btns;
                    Btns.BackColor = ThemeColor.PrimaryColor;
                    Btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label4.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;


        }
    }
}
