using DiyetUygulama.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.SERVICE.Interfaces
{
    public interface ILoginInfoSERVICE
    {
        int Add(LoginInfo entity);
        int Update(LoginInfo entity);
        int Delete(LoginInfo entity);
        List<LoginInfo> GetAll();
        List<LoginInfo> GetAllActive();
        List<LoginInfo> GetWhere(Func<LoginInfo, bool> expression);
    }
}
