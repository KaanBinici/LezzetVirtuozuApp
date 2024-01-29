using DiyetUygulama.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DAL.Interfaces
{
    public interface IAdminREPO : IBaseREPO<Admin>
    {
        List<Admin> GetAllOrderByName();
    }
}
