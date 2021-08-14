using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult New()
        {
            return View();
        }
        public ActionResult AddEmployee(Employee employee)
        {
            var db = new dbContext();
            
            // get existing department and designation with with a particular ID
            var department = db.Departments.FirstOrDefault(x => x.Id == employee.Department.Id);
            employee.Department = department;

            var designation = db.Designations.FirstOrDefault(x => x.Id == employee.Designation.Id);
            employee.Designation = designation;

            db.Employees.Add(employee);
            db.SaveChanges();

            return View("AllEmployee");
        }
        public ActionResult AllEmployee()
        {
            var model = new List<Employee>();

            var db = new dbContext();
            model = db.Employees.ToList();

            return View(model);
        }
    }
}