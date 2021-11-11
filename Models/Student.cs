using System.Security.Cryptography;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models
{
    [Table("Student")]
    public class Student
    {   
        
        public string StudentID { get; set; }
        public string StudentName{ get; set; }
        public string Address{ get; set; }
        
    }
}