
using System.Security.Cryptography;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models
{
    [Table("Product")]
    public class Product
    {   
        
        public string ProductID { get; set; }
        public string ProductName{ get; set; }
        public decimal UnitPrice{ get; set; }
        public int Quantity{ get; set; }
    }
}
