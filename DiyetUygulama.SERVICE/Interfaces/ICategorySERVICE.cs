using DiyetUygulama.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.SERVICE.Interfaces
{
    public interface ICategorySERVICE
    {
        int Add(Category entity);
        int Update(Category entity);
        int Delete(Category entity);
        List<Category> GetAll();
        List<Category> GetWhere(Func<Category, bool> expression);
    }
}
