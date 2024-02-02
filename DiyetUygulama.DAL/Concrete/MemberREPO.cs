using DiyetUygulama.DAL.Contexts;
using DiyetUygulama.DAL.Interfaces;
using DiyetUygulama.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DAL.Concrete
{
    public class MemberREPO : BaseREPO<Member>, IMemberREPO
    {
        private readonly DiyetUygulamasiContext db;
        public MemberREPO()
        {
            db = new DiyetUygulamasiContext();
        }
        public Member GetMemberByEmail(string email)
        {
            return db.Members.FirstOrDefault(m => m.Email == email);
        }
    }
}
