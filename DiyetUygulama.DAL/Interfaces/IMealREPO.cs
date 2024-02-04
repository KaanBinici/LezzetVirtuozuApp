using DiyetUygulama.DATA.Entities;
using DiyetUygulama.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DAL.Interfaces
{
    public interface IMealREPO : IBaseREPO<Meal>
    {
        Meal GetMeal(Meals meal,int memberId);

        Meal GetMealByMealIdDate(Meals meal, int memberId, DateTime date);
        bool IsThereAnyWithMealDate(Meals meal);
    }
}
