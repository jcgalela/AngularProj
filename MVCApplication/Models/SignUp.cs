﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCApplication.Models
{
    public class SignUp
    {

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


        [Table("Employee")]
        public class Employee
        {
            [Key]
            [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]

            public string employeeId { get; set; }

            public string firstName { get; set; }

        }
    }
}