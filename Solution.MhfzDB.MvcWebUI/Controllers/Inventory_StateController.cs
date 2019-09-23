using Microsoft.AspNetCore.Mvc;
using Solution.MhfzDB.Business.Abstract;
using Solution.MhfzDB.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.MhfzDB.MvcWebUI.Controllers
{
    public class Inventory_StateController:Controller
    {
        private IInventory_StateService _inventory_stateService;
        public Inventory_StateController(IInventory_StateService inventory_stateService)
        {
            _inventory_stateService = inventory_stateService;
        }
        public ActionResult Index()
        {
            var inventory_States = _inventory_stateService.GetAll();
            Inventory_StateListViewModel model = new Inventory_StateListViewModel
            {
                Inventory_States = inventory_States
            };
            return View(model);
        }
    }
}
