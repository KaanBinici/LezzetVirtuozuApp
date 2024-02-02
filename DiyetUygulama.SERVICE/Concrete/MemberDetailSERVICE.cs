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
    public class MemberDetailSERVICE : IMemberDetailSERVICE
    {
        private readonly IMemberDetailREPO _memberDetailREPO;
        public MemberDetailSERVICE()
        {
            _memberDetailREPO = new MemberDetailREPO();
        }

        public int Add(MemberDetail entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = BaseStatus.Added;
            return _memberDetailREPO.Create(entity);
        }

        public int Delete(MemberDetail entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = BaseStatus.Deleted;
            return _memberDetailREPO.Update(entity);
        }

        public List<MemberDetail> GetAll()
        {
            return _memberDetailREPO.GetAll();
        }

        public MemberDetail GetMemberById(int id)
        {
            return _memberDetailREPO.GetMemberById(id);
        }

        public List<MemberDetail> GetWhere(Func<MemberDetail, bool> expression)
        {
            return _memberDetailREPO.GetAll().Where(expression).ToList();
        }

        public int Update(MemberDetail entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.Status = BaseStatus.Modified;
            return _memberDetailREPO.Update(entity);
        }
    }
}
