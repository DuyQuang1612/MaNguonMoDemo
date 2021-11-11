using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;
namespace DemoMVC.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<DemoMVC.Models.Movie> Movie { get; set; }

        public DbSet<DemoMVC.Models.Person> Person { get; set; }

        public DbSet<DemoMVC.Models.Student> Student { get; set; }

        public DbSet<DemoMVC.Models.Employee> Employee { get; set; }

        public DbSet<DemoMVC.Models.Product> Product { get; set; }
        
    }
}