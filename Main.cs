using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystem
{
    public class Main
    {
        public static List<Department> GetDepartment()
        {
            var model = new List<Department>();

            var db = new dbContext();
            model = db.Departments.ToList();
            return model;
        }
        public static List<Designation> GetDesignamtion()
        {
            var model = new List<Designation>();

            var db = new dbContext();
            model = db.Designations.ToList();
            return model;
        }
    }
}