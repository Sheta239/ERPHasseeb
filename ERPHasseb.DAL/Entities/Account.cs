using System;
using System.Collections.Generic;
using System.Text;

namespace ERPHasseb.DAL.Entities
{
    public class Account
    {
        public int AccountID { get; set; }
        public Nullable<int> AccountNatureID { get; set; }
        public Nullable<int> ParentAccountID { get; set; }
        public string AccountSerial { get; set; }
        public string AccountName { get; set; }
        public string AccountDesc { get; set; }
        public int GroupOrder { get; set; }
        public bool Active { get; set; }
        public System.DateTime AddDate { get; set; }
        public bool IsMain { get; set; }

    }
}
