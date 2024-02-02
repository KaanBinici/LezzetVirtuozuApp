using DiyetUygulama.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DAL.Interfaces
{
    public interface IMemberREPO : IBaseREPO<Member>
    {
        Member GetMemberByEmail(string email);
    }
}
