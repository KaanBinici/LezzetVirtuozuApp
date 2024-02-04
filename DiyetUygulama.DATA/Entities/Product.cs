using DiyetUygulama.DATA.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DATA.Entities
{
    public class Product : BaseEntity
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public double? Amount { get; set; }
        public string? Unit { get; set; }
        public string? Portion { get; set; }
        public double? Calories { get; set; }
        public double?Protein { get; set; }
        public double? Carbonhydrate { get; set; }
        public double? Fat { get; set; }
        public bool? HasGluten { get; set; }
        public bool? HasLactose { get; set; }
        public string? PhotoPath { get; set; }
        public bool? Visible { get; set; } = true;


        //Navigation Proporties
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int MealId { get; set; }
        public virtual Meal Meal { get; set; }
    }
}
