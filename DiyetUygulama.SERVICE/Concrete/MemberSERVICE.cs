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
    public class MemberSERVICE : IMemberSERVICE
    {
        private readonly IMemberREPO _memberREPO;
        public MemberSERVICE()
        {
            _memberREPO = new MemberREPO();
        }

        public int Add(Member entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = BaseStatus.Added;
            return _memberREPO.Create(entity);
        }

        public int Delete(Member entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = BaseStatus.Deleted;
            return _memberREPO.Update(entity);
        }

        public List<Member> GetAll()
        {
            return _memberREPO.GetAll();
        }

        public List<Member> GetAllActive()
        {
            return _memberREPO.GetAllWhere(x=>x.Status !=BaseStatus.Deleted).ToList();
        }

        public List<Member> GetWhere(Func<Member, bool> expression)
        {
            return _memberREPO.GetAll().Where(expression).ToList();
        }

        public int Update(Member entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.Status = BaseStatus.Modified;
            return _memberREPO.Update(entity);
        }
    }
}
