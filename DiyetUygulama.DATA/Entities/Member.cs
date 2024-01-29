using DiyetUygulama.DATA.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DATA.Entities
{
    public class Member : BaseEntity
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }
        public DateTime MembershipDate { get; set; } = DateTime.Now;
        public string PhotoPath { get; set; }


        //Navigation Properies
        public MemberDetail MemberDetail { get; set; }
        public LoginInfo LoginInfo { get; set; }
        public ICollection<Meal> Meals { get; set; }


    }
}
