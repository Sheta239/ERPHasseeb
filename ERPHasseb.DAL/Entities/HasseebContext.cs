using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERPHasseb.DAL.Entities
{
    public class HasseebContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=NewHasseeb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
       

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountNature> AccountNatures { get; set; }

        public HasseebContext(DbContextOptions<HasseebContext> options)
       : base(options)
        { }
    }
}
