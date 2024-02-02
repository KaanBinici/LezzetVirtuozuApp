using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LezzetVirtuozuApp.UIFORM.Metotlar
{
    public class labelRenkveAltCizgi
    {

        public static void Label_MouseEnter(object sender, EventArgs e)
        {

            (sender as Label).ForeColor = Color.Red;
            (sender as Label).Font = new Font((sender as Label).Font, FontStyle.Underline);
        }

        public static void Label_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.Black;
            (sender as Label).Font = new Font((sender as Label).Font, FontStyle.Regular);
        }
    }
}
