using DiyetUygulama.DAL.Concrete;
using DiyetUygulama.DAL.Interfaces;
using DiyetUygulama.DATA.Entities;
using DiyetUygulama.DATA.Enums;
using DiyetUygulama.SERVICE.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.SERVICE.Concrete
{
    public class AdminSERVICE : IAdminSERVICE
    {
        private readonly IAdminREPO _adminREPO;
        public AdminSERVICE()
        {
            _adminREPO = new AdminREPO();

        }
        public int Add(Admin entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = BaseStatus.Added;
            return _adminREPO.Create(entity);
        }

        public int Delete(Admin entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = BaseStatus.Deleted;
            return _adminREPO.Update(entity);
        }

        public List<Admin> GetAll()
        {
            return _adminREPO.GetAll();
        }

        public List<Admin> GetAllActive()
        {
            return _adminREPO.GetAllWhere(x => x.Status != BaseStatus.Deleted);
        }

        public List<Admin> GetWhere(Func<Admin, bool> expression)
        {
            return _adminREPO.GetAll().Where(expression).ToList();
        }

        public int Update(Admin entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.Status = BaseStatus.Modified;
            return _adminREPO.Update(entity);
        }
    }
}
