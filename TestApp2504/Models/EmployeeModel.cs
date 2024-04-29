using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace TestApp2504.Models
{
    public class EmployeeModel
    {
        [Key]
        [Display (Name = "ID")]
        public int EMPId { get; set; }

        [Required(ErrorMessage ="EmpName Is Required.")]
        public string EmpName { get; set; }

        public DateTime DOJ { get; set; }

        [Required(ErrorMessage = "Department IS Required.")]

        [Display(Name = "Department Name")]
        public int DeptID { get; set; }
        [Required(ErrorMessage = "Salary IS Required.")]
        public decimal salary { get; set; }
        [Required(ErrorMessage = "WorkingPlace is Required.")]
        public string WorkingPlace { get; set; }
        [Required(ErrorMessage = "AGE IS Required.")]
        public int AGE { get; set; }
        [Required(ErrorMessage = "Gender IS Required.")]
        public string Gender { get; set; }





    }
}