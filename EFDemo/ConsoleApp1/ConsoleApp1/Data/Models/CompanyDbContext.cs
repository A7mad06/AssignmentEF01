using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data.Models
{
    internal class CompanyDbContext:DbContext
    {
        public CompanyDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0GB12AQ;Database=Company;Trusted_Connection=True;trustservercertificate=true;");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
