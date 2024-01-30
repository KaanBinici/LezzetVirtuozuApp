﻿using DiyetUygulama.DAL.Concrete;
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
    public class LoginInfoSERVICE : ILoginInfoSERVICE
    {
        private readonly ILoginInfoREPO _loginInfoREPO;
        public LoginInfoSERVICE()
        {
            _loginInfoREPO = new LoginInfoREPO();
        }

        public int Add(LoginInfo entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = BaseStatus.Added;
            return _loginInfoREPO.Create(entity);
        }

        public int Delete(LoginInfo entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = BaseStatus.Deleted;
            return _loginInfoREPO.Update(entity);
        }

        public List<LoginInfo> GetAll()
        {
            return _loginInfoREPO.GetAll();
        }

        public List<LoginInfo> GetAllActive()
        {
            return _loginInfoREPO.GetAllWhere(x=>x.Status != BaseStatus.Deleted);
        }

        public List<LoginInfo> GetWhere(Func<LoginInfo, bool> expression)
        {
            return _loginInfoREPO.GetAll().Where(expression).ToList();
        }

        public int Update(LoginInfo entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.Status = BaseStatus.Modified;
            return _loginInfoREPO.Update(entity);
        }
    }
}