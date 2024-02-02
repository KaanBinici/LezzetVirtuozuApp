using DiyetUygulama.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.SERVICE.Interfaces
{
    public interface IMemberDetailSERVICE
    {
        int Add(MemberDetail entity);
        int Update(MemberDetail entity);
        int Delete(MemberDetail entity);
        List<MemberDetail> GetAll();
        List<MemberDetail> GetWhere(Func<MemberDetail, bool> expression);
        MemberDetail GetMemberById(int id);
    }
}
