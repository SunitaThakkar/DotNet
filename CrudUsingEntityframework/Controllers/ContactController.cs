using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CrudUsingEntityframework;
using CrudUsingEntityframework.DAL;
using CrudUsingEntityframework.Models;

namespace CrudUsingEntityframework.Controllers
{
    public class ContactController : Controller
    {

        private readonly ContactDAL _contactdal;

        private ContactController()
        {
            _contactdal = new ContactDAL(new ContactDbContext());
        }

        // GET: ContactMasters
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContactMasters/Details/5
        public ActionResult GetContacts()
        {
            var contacts = _contactdal.GetContact();
                return Json(contacts, JsonRequestBehavior.AllowGet);
        }

        // GET: ContactMasters/Create
        public ActionResult Create()
        {
            return View();
        }

        
    }
}
