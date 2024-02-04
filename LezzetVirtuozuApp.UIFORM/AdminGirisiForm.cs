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
    public partial class AdminGirisiForm : Form
    {
        public AdminGirisiForm()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void pbKilitFoto_Click(object sender, EventArgs e)
        {
            if (txtSifre.UseSystemPasswordChar == true)
                txtSifre.UseSystemPasswordChar = false;
            else
                txtSifre.UseSystemPasswordChar = true;
        }

    }
}
