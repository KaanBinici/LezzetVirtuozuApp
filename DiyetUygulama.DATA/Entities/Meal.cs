using DiyetUygulama.DATA.Abstracts;
using DiyetUygulama.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DATA.Entities
{
    public class Meal : BaseEntity
    {
        public Meal()
        {
            Products = new HashSet<Product>();
        }

        public int  MealId { get; set; }
        public Meals MealType { get; set; }
        public DateTime MealDate { get; set; } = DateTime.Now;
        public int? WaterConsumption { get; set; }


        public virtual ICollection<Product> Products { get; set; }
        public int MemberId { get; set; }
        public virtual Member Member { get; set; }
    }
}
