using DiyetUygulama.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.SERVICE.Interfaces
{
    public interface IMealSERVICE
    {
        int Add(Meal entity);
        int Update(Meal entity);
        int Delete(Meal entity);
        List<Meal> GetAll();
        List<Meal> GetWhere(Func<Meal, bool> expression);
    }
}
