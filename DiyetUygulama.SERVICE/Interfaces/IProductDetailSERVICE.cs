using DiyetUygulama.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.SERVICE.Interfaces
{
    public interface IProductDetailSERVICE
    {
        int Add(ProductDetail entity);
        int Update(ProductDetail entity);
        int Delete(ProductDetail entity);
        List<ProductDetail> GetAll();
        List<ProductDetail> GetWhere(Func<ProductDetail, bool> expression);
    }
}
