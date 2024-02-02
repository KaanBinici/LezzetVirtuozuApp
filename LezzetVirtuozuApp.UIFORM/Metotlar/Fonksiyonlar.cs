using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LezzetVirtuozuApp.UIFORM.Metotlar
{
    public class Fonksiyonlar
    {
        public static void Clean(Control.ControlCollection controls)
        {
            foreach (Control item in controls)
            {
                if (item is TextBox)
                {
                    if (item.Enabled==true)
                    {
                        ((TextBox)item).Clear();
                    }
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
                else if(item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
                else if (item is GroupBox)
                {
                    Clean(item.Controls);
                }
            }
        }
        public static double FatRatioCalculate(bool gender, string height, string neck, string waist, string hip)
        {
            double ratio;

            if (gender == true)
            {
                ratio = 495 / (1.0324 - 0.19077 * Math.Log10(Convert.ToDouble(waist) - Convert.ToDouble(neck)) + 0.15456 * Math.Log10(Convert.ToDouble(height))) - 450;
            }
            else
            {
                ratio = 495 / (1.29579 - 0.35004 * Math.Log10(Convert.ToDouble(waist) + Convert.ToDouble(hip) - Convert.ToDouble(neck)) + 0.22100 * Math.Log10(Convert.ToDouble(height))) - 450;
            }

            return ratio;
        }

    }
}
