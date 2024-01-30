using DiyetUygulama.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.SERVICE.Interfaces
{
    public interface IMemberSERVICE
    {
        int Add(Member entity);
        int Update(Member entity);
        int Delete(Member entity);
        List<Member> GetAll();
        List<Member> GetAllActive();
        List<Member> GetWhere(Func<Member, bool> expression);
    }
}
