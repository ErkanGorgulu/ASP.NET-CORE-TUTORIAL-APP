using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WEB_APP.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Eric",
                    Department = Dept.IT,
                    Email = "erkangorgulu@gmail.com",
                    PhotoPath = null
                    
                },
                new Employee
                {
                    Id = 2,
                    Name = "April",
                    Department = Dept.HR,
                    Email = "aprilLegget@gmail.com",
                    PhotoPath = null
                },
                new Employee
                {
                    Id = 3,
                    Name = "Alejandro",
                    Department = Dept.Accountancy,
                    Email = "Alejandroxx@gmail.com",
                    PhotoPath = null
                }
            );
        }
    }
}
