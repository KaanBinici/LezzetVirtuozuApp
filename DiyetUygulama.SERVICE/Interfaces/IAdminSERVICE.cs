using DiyetUygulama.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.SERVICE.Interfaces
{
    public interface IAdminSERVICE
    {
        int Add(Admin entity);
        int Update(Admin entity);
        int Delete(Admin entity);
        List<Admin> GetAll();
        List<Admin> GetAllActive();
        List<Admin> GetWhere(Func<Admin,bool> expression);
        
    }
}
