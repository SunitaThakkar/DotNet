using CrudUsingEntityframework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudUsingEntityframework
{
    public class ContactDbContext : DbContext
    {
        public DbSet<ContactMaster> contactMasters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactMaster>().MapToStoredProcedures();
            base.OnModelCreating(modelBuilder);
        }
    }
}
