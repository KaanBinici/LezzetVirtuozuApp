using DiyetUygulama.DATA.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DATA.Entities
{
    public class Admin : BaseLogin
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminSurname { get; set; }
    }
}
