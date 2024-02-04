using DiyetUygulama.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.SERVICE.Interfaces
{
    public interface IProductSERVICE
    {
        int Add(Product entity);
        int Update(Product entity);
        int SoftDelete(Product entity);
        int Delete(Product entity);
        List<Product> GetAll();
        List<Product> GetWhere(Func<Product, bool> expression);
    }
}
