using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public DateTime JoiningDate { get; set; }
        public virtual Department Department { get; set; }
        public virtual Designation Designation { get; set; }
        public bool Active { get; set; }

    }
}