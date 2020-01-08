using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCApplication.Models
{
    public class SignUp
    {
        [Required(ErrorMessage = "This is required!")]
        [DataType(DataType.Text)]
        [StringLength(10)]
        public string employeeId { get; set; }

        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string birthday { get; set; }
        public string emergencyName { get; set; }
        public string emergencyAddress { get; set; }
        public string emergencyContact { get; set; }
        public string employeeStatus { get; set; }
        public string sssnum { get; set; }
        public string tinnum { get; set; }
        public string dateEmployed { get; set; }
        public string dateFrom { get; set; }
        public string dateTo { get; set; }
        public string signature { get; set; }

        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$",
        ErrorMessage = "Please provide valid email id")]
        public string email { get; set; }
        
        [Compare("email", ErrorMessage = "Confirm email dose not match.")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
        public string Confirmemail { get; set; }

        public string image { get; set; }
        
        [Required(ErrorMessage = "Please enter user name.")]
        [DataType(DataType.Text)]       
        [StringLength(30)]
        public string userName { get; set; }
        
        [Required(ErrorMessage = "Please enter password.")]
        [DataType(DataType.Password)]
        [StringLength(10)]
        public string password { get; set; }

        [Compare("password", ErrorMessage = "Confirm password dose not match.")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Confirmpassword { get; set; }

        [Table("Employee")]
        public class Employees
        {
            [Key]
            [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]

            public string employeeId { get; set; }

            public string firstName { get; set; }
            public string middleName { get; set; }
            public string lastName { get; set; }
            public string birthday { get; set; }
            public string emergencyName { get; set; }
            public string emergencyAddress { get; set; }
            public string emergencyContact { get; set; }
            public string employeeStatus { get; set; }
            public string sssnum { get; set; }
            public string tinnum { get; set; }
            public string dateEmployed { get; set; }
            public string dateFrom { get; set; }
            public string dateTo { get; set; }
            public string signature { get; set; }

            public string email { get; set; }

            public string image { get; set; }

            public string userName { get; set; }

            public string password { get; set; }

        }
    }
}