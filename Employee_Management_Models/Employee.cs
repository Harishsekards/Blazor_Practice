using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Employee_Management_Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="First Name must be provided")]
        [MinLength(3,ErrorMessage ="First Name must be minimum of 3 characters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name must be provided")]
        [MinLength(3, ErrorMessage = "Last Name must be minimum of 3 characters")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }        
        public Gender Gender { get; set; }
        public Department Department { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Photopath { get; set; }
    }
}
