using DiyetUygulama.DAL.Concrete;
using DiyetUygulama.DAL.Interfaces;
using DiyetUygulama.DATA.Entities;
using DiyetUygulama.DATA.Enums;
using DiyetUygulama.SERVICE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.SERVICE.Concrete
{
    public class CategorySERVICE : ICategorySERVICE
    {
        private readonly ICategoryREPO _categoryREPO;
        public CategorySERVICE()
        {
            _categoryREPO = new CategoryREPO();
        }

        public int Add(Category entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = BaseStatus.Added;
            return _categoryREPO.Create(entity);
        }

        public int Delete(Category entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = BaseStatus.Deleted;
            return _categoryREPO.Update(entity);
        }

        public List<Category> GetAll()
        {
            return _categoryREPO.GetAll();
        }

        public List<Category> GetWhere(Func<Category, bool> expression)
        {
            return _categoryREPO.GetAll().Where(expression).ToList();
        }

        public int Update(Category entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.Status = BaseStatus.Modified;
            return _categoryREPO.Update(entity);
        }
    }
}
