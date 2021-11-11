using System.Security.Cryptography;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models
{
    [Table("Employee")]
    public class Employee
    {   
        
        public string EmployeeID { get; set; }
        public string EmployeeName{ get; set; }
        public string PhoneNumber{ get; set; }
        
    }
}
