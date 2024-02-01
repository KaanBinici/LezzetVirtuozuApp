using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DATA.Abstracts
{
    public abstract class BaseLogin :BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
