using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp2504.Models;
using TestApp2504.Repository;

namespace TestApp2504.Controllers
{
    public class EmployeeController : Controller
    {
        EmpRepo objempRepo = new EmpRepo();
        // GET: Employee
        
        [HttpGet]
        public ActionResult Index()
        {
            ModelState.Clear();
            return View(objempRepo.GetEmployees());
        }

        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(EmployeeModel objempmodel)
        {
            try
            {
                if (objempRepo.ADDEmployee(objempmodel))
                {
                    ViewBag.Message = "Employee details Added Sucessfully..";
                }
                return View();
            }
            catch
            {
                return View() ;
            }
        }

        [HttpGet]
        public ActionResult UpdateEmployee(int id )
        {
            return View(objempRepo.GetEmployees().Find(S => S.EMPId == id));
        }

        [HttpPost]
        public ActionResult UpdateEmployee(EmployeeModel objempmodel , int id)
        {
            objempRepo.UpdateEmployee(objempmodel);
            return View();
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var data = objempRepo.GetEmployees().Where(S => S.EMPId == id).FirstOrDefault();
            return View(data);
        }

        [HttpPost]
        public ActionResult Details(EmployeeModel objempmodel, int id)
        {
            objempRepo.GetEmployeeByID(objempmodel);
            return View();
        }

        [HttpGet]
        //public ActionResult Delete(int id)
        //{
        //    var data = objempRepo.GetEmployees().Where(S => S.EMPId == id).FirstOrDefault();
        //    return View(data);
        //}
        //[HttpPost]        
        public ActionResult Delete(int id)
        {
            try
            {
                if (objempRepo.DeleteEmployee(id))
                {
                    ViewBag.message = "Employee Details Deleted SucessFully...!";
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
        
    }
}