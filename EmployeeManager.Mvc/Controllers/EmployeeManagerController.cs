using EmployeeManager.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace EmployeeManager.Mvc.Controllers
{
    public class EmployeeManagerController:Controller
    {
        private AppDbContext db = null;
        public EmployeeManagerController(AppDbContext Db)
        {
            this.db = Db;
        }
        //private void FillCountries()
        //{
        //    List<SelectListItem> countries = (from c in db.Countries
        //                                      orderby c.Name ascending
        //                                      select new SelectListItem() { Text = c.Name, Value = c.Name }).ToList();

        //    ViewBag.Countries = countries;
        //}
        public IActionResult List()
        {
            List<Employee> model = (from e in db.Employees
                                    orderby e.EmployeeID
                                    select e).ToList();
            return View(model);
        }

    }
}
