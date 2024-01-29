using DiyetUygulama.DAL.Contexts;
using DiyetUygulama.DAL.Interfaces;
using DiyetUygulama.DATA.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DAL.Concrete
{
    public class BaseREPO<T> : IBaseREPO<T> where T : BaseEntity
    {
        private readonly DiyetUygulamasiContext db;
        public BaseREPO()
        {
            db = new DiyetUygulamasiContext();
        }

        public int Create(T entity)
        {
            if (entity is not null)
            {
                db.Add(entity);
                return db.SaveChanges();
            }
            throw new Exception("Entity cannot be null.");
        }

        public int Delete(T entity)
        {
            if (entity is not null)
            {
                db.Remove(entity);
                return db.SaveChanges();
            }
            throw new Exception("Entity cannot be null.");
        }

        public List<T> GetAll()
        {
            var list = db.Set<T>().ToList();
            if (list is not null)
            {
                return list;
            }
            throw new Exception("Couldn't find the data.");
        }

        public List<T> GetAllWhere(Expression<Func<T, bool>> expression)
        {
            return db.Set<T>().Where(expression).ToList();
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public int Update(T entity)
        {
            db.Update(entity);
            return db.SaveChanges();
        }
    }
}
