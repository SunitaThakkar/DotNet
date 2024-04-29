using CrudUsingEntityframework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudUsingEntityframework.DAL
{
    public class ContactDAL
    {
        private readonly ContactDbContext _context;

        public ContactDAL(ContactDbContext context)
        {
            _context = context;
        }

        public ContactMaster GetContact()
        {
            // Implement logic to get contact by ID
            return _context.contactMasters.ToList();
        }


    }
}