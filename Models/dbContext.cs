using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystem.Models
{
    public class dbContext : DbContext
    {
        public dbContext() : base("EmployeeManagementSystem")
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}