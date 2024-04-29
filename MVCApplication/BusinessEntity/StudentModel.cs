using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class StudentModel
    {
        [Key]
        [Display(Name = "ID")]
        public int S_Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Student name is required.")]
        public string S_Name { get; set; }

        [Display(Name = "AGE")]
        [Required(ErrorMessage = "Student AGE is required")]
        public int S_Age { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Student Email is required.")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression("[a-z0-9._%+-]+@[a-z0-9.-]+[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string S_Email { get; set; }


    }
}
