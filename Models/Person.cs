using System.Security.Cryptography;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models
{
    [Table("Person")]
    public class Person
    {   
        
        public string PersonID { get; set; }
        public string PersonName{ get; set; }

        
    }
}