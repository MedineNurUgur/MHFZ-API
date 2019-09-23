using Microsoft.AspNetCore.Mvc;
using Solution.MhfzDB.Business.Abstract;
using Solution.MhfzDB.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.MhfzDB.MvcWebUI.Controllers
{
    public class EmployeeController:Controller
    {
        private IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public ActionResult Index()
        {
            var employees = _employeeService.GetAll();
            EmployeeListViewModel model = new EmployeeListViewModel
            {
                Employees = employees
            };
            return View(model);
        }
    }
}
