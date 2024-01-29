using DiyetUygulama.DATA.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DATA.Entities
{
    public class ProductDetail : BaseEntity
    {
        public int ProductDetailId { get; set; }
        public bool HasGluten { get; set; }
        public bool HasLactose { get; set; }
        public double Protein { get; set; }
        public double Carbonhydrate { get; set; }
        public double Sugar { get; set; }


        //Navigation Properties
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
