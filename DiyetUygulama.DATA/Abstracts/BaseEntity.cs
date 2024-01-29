using DiyetUygulama.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DATA.Abstracts
{
    public abstract class BaseEntity
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public BaseStatus Status { get; set; } = BaseStatus.Added;
    }
}
