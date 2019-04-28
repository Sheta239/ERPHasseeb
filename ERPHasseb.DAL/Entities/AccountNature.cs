using System;
using System.Collections.Generic;
using System.Text;

namespace ERPHasseb.DAL.Entities
{
    public class AccountNature
    {
        public AccountNature()
        {
            this.Accounts = new HashSet<Account>();
        }

        public int AccountNatureID { get; set; }
        public string AccountNatureName { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
