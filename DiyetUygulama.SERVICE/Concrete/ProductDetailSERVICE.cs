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
    public class ProductDetailSERVICE : IProductDetailSERVICE
    {
        private readonly IProductDetailREPO _productDetailREPO;
        public ProductDetailSERVICE()
        {
            _productDetailREPO = new ProductDetailREPO();
        }

        public int Add(ProductDetail entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = BaseStatus.Added;
            return _productDetailREPO.Create(entity);
        }

        public int Delete(ProductDetail entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = BaseStatus.Deleted;
            return _productDetailREPO.Update(entity);
        }

        public List<ProductDetail> GetAll()
        {
            return _productDetailREPO.GetAll();
        }

        public List<ProductDetail> GetWhere(Func<ProductDetail, bool> expression)
        {
            return  _productDetailREPO.GetAll().Where(expression).ToList();
        }

        public int Update(ProductDetail entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.Status = BaseStatus.Modified;
            return _productDetailREPO.Update(entity);
        }
    }
}
