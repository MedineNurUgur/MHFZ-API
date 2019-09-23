using Microsoft.AspNetCore.Mvc;
using Solution.MhfzDB.Business.Abstract;
using Solution.MhfzDB.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.MhfzDB.MvcWebUI.Controllers
{
    public class CompanyController:Controller
    {
       /* private ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }*/
        public ActionResult Index()
        {
            /*var companies = _companyService.GetAll();
            CompanyListViewModel model = new CompanyListViewModel
            {
                Companies = companies
            };*/
            return View();
        }
    }
}
