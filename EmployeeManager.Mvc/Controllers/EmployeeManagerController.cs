using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManager.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManager.Mvc.Controllers
{
    public class EmployeeManagerController : Controller
    {
        private AppDbContext db = null;
        public EmployeeManagerController(AppDbContext db)
        {
            this.db = db;
        }

        public IActionResult List()
        {
            List<Employee> model = (from e in db.Employees
                                    orderby e.EmployeeID
                                    select e).ToList();
            return View(model);
        }
    }
}