using System;
using System.ComponentModel.DataAnnotations;


namespace CrudUsingEntityframework.Models
{
    public class ContactMaster
    {
        [Key]
        public int ContactID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]

        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Contact number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string ContactNo { get; set; }

        public string Address { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }


    }
}