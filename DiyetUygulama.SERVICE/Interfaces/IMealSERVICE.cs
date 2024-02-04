using DiyetUygulama.DATA.Entities;
using DiyetUygulama.DATA.Enums;
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
        Meal GetMeal(Meals meal, int memberId);

        Meal GetMealByMealIdDate(Meals meal, int memberId, DateTime date);
    }
}
