using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data.Models
{
    //Poco Class
    internal class Employee
    {
        //1-TPC
        public int Id { get; set; }
        //Id or EmployeeId = Primary key identity(1,1)
        public string? Name { get; set; }
        //nvarchar(max)
        public decimal Salary { get; set; }
        //float
        public int? Age { get; set; }
        //int nullable
    }
}
