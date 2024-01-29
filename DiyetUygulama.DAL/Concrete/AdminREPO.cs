using DiyetUygulama.DAL.Contexts;
using DiyetUygulama.DAL.Interfaces;
using DiyetUygulama.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DAL.Concrete
{
    public class AdminREPO : BaseREPO<Admin>, IAdminREPO
    {
        private readonly DiyetUygulamasiContext db;
        public AdminREPO()
        {
            db = new DiyetUygulamasiContext();
        }
        public List<Admin> GetAllOrderByName()
        {
            return db.Admins.OrderBy(x => x.AdminName).ToList();
        }
    }
}
