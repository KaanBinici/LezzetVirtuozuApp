using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DATA.Enums
{
    public enum Meals
    {

        Sabah,
        [Display(Name = "Öğle")]
        Ogle,
        [Display(Name = "Akşam")]
        Aksam
    }
}
