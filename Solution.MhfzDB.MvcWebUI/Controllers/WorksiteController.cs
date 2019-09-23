using Microsoft.AspNetCore.Mvc;
using Solution.MhfzDB.Business.Abstract;
using Solution.MhfzDB.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.MhfzDB.MvcWebUI.Controllers
{
    public class WorksiteController:Controller
    {
        private IWorksiteService _worksiteService;
        public WorksiteController(IWorksiteService worksiteService)
        {
            _worksiteService = worksiteService;
        }
        public ActionResult Index()
        {
            var worksites = _worksiteService.GetAll();
            WorksiteListViewModel model = new WorksiteListViewModel
            {
                Worksites = worksites
            };
            return View(model);
        }
    }
}
