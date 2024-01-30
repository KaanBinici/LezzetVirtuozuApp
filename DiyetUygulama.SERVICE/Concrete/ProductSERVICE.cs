using DiyetUygulama.DAL.Concrete;
using DiyetUygulama.DAL.Interfaces;
using DiyetUygulama.DATA.Entities;
using DiyetUygulama.DATA.Enums;
using DiyetUygulama.SERVICE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.SERVICE.Concrete
{
    public class ProductSERVICE : IProductSERVICE
    {
        private readonly IProductREPO _productREPO;
        public ProductSERVICE()
        {
            _productREPO = new ProductREPO();
        }
        public int Add(Product entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = BaseStatus.Added;
            return _productREPO.Create(entity);
        }

        public int Delete(Product entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = BaseStatus.Deleted;
            return _productREPO.Update(entity);
        }

        public List<Product> GetAll()
        {
            return _productREPO.GetAll();
        }

        public List<Product> GetWhere(Func<Product, bool> expression)
        {
            return _productREPO.GetAll().Where(expression).ToList();
        }

        public int Update(Product entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.Status = BaseStatus.Modified;
            return _productREPO.Update(entity);
        }
    }
}
