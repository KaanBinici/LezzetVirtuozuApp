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
        public Member()
        {
            Meals = new HashSet<Meal>();
        }

        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }
        public DateTime MembershipDate { get; set; } = DateTime.Now;
        public string PhotoPath { get; set; }


        //Navigation Properies
        public virtual MemberDetail MemberDetail { get; set; }
        public virtual LoginInfo LoginInfo { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
    }
}
