using DiyetUygulama.DAL.Contexts;
using DiyetUygulama.DAL.Interfaces;
using DiyetUygulama.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DAL.Concrete
{
    public class MemberDetailREPO : BaseREPO<MemberDetail>, IMemberDetailREPO
    {
        private readonly DiyetUygulamasiContext db;
        public MemberDetailREPO()
        {
            db = new DiyetUygulamasiContext();
        }
        public MemberDetail GetMemberById(int id)
        {
            return db.MemberDetails.FirstOrDefault(x=>x.MemberId == id);
        }
    }
}
