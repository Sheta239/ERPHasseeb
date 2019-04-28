using ERPHasseb.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERPHasseb.DAL.Repository.Interface
{
    public interface IAccountNature
    {
        IEnumerable<AccountNature> GetAll();
        AccountNature GetByID(int Id);
        void Insert(AccountNature entity);
        void Update(AccountNature entity);
        void Delete(AccountNature entity);

    }
}
