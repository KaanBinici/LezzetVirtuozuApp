using DiyetUygulama.DATA.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DATA.Entities
{
    public class LoginInfo : BaseEntity
    {
        public int LoginInfoId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }

        //Navigation Properties
        public int MemberId { get; set; }
        public virtual Member Member { get; set; }
        public int AdminId { get; set; }
        public virtual Admin Admin { get; set; }
    }
}
