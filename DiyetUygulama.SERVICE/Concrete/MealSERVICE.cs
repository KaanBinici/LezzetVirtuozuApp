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
    public class MealSERVICE : IMealSERVICE
    {
        private readonly IMealREPO _mealREPO;
        public MealSERVICE()
        {
            _mealREPO = new MealREPO();
        }

        public int Add(Meal entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = BaseStatus.Added;
            return _mealREPO.Create(entity);
        }

        public int Delete(Meal entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = BaseStatus.Deleted;
            return _mealREPO.Update(entity);
        }

        public List<Meal> GetAll()
        {
            return _mealREPO.GetAll();
        }

        public Meal GetMeal(Meals meal, int memberId)
        {
            return _mealREPO.GetMeal(meal, memberId);
        }

        public Meal GetMealByMealIdDate(Meals meal, int memberId, DateTime date)
        {
            return _mealREPO.GetMealByMealIdDate(meal, memberId, date);
        }

        public List<Meal> GetWhere(Func<Meal, bool> expression)
        {
            return _mealREPO.GetAll().Where(expression).ToList();
        }

        public int Update(Meal entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.Status = BaseStatus.Modified;
            return _mealREPO.Update(entity);
        }
    }
}
