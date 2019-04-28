using ERPHasseb.DAL.Entities;
using ERPHasseb.DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ERPHasseb.DAL.Repository.Repo
{
    public class AccountNatureRepo : IAccountNature
    {
        private readonly HasseebContext _context;
        public AccountNatureRepo(HasseebContext context)
        {
            _context = context;
        }

        public void Delete(AccountNature entity)
        {
            _context.AccountNatures.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<AccountNature> GetAll()
        {
            return _context.AccountNatures.ToList();
        }

        public AccountNature GetByID(int Id)
        {
            return _context.AccountNatures.FirstOrDefault(A => A.AccountNatureID == Id);
        }

        public void Insert(AccountNature entity)
        {
            _context.AccountNatures.Add(entity);
            _context.SaveChanges();

        }

        public void Update(AccountNature entity)
        {
            AccountNature Edited = _context.AccountNatures.FirstOrDefault(A => A.AccountNatureID == entity.AccountNatureID);

            AccountNature newAcc = new AccountNature();
            newAcc.AccountNatureID = Edited.AccountNatureID;
            newAcc.AccountNatureName = Edited.AccountNatureName;
            _context.AccountNatures.Update(newAcc);
            _context.SaveChanges();

        }
    }
}
