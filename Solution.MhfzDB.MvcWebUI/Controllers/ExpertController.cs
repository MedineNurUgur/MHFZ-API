using Microsoft.AspNetCore.Mvc;
using Solution.MhfzDB.Business.Abstract;
using Solution.MhfzDB.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.MhfzDB.MvcWebUI.Controllers
{
    public class ExpertController:Controller
    {
        private IExpertService _expertService;
        public ExpertController(IExpertService expertService)
        {
            _expertService = expertService;
        }
        public ActionResult Index()
        {
            var experts = _expertService.GetAll();
            ExpertListViewModel model = new ExpertListViewModel
            {
                Experts = experts
            };
            return View(model);
        }
    }
}
