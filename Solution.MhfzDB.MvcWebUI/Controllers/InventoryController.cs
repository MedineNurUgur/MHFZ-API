using Microsoft.AspNetCore.Mvc;
using Solution.MhfzDB.Business.Abstract;
using Solution.MhfzDB.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.MhfzDB.MvcWebUI.Controllers
{
    public class InventoryController:Controller
    {
        private IInventoryService _inventoryService;
        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }
        public ActionResult Index()
        {
            var inventories = _inventoryService.GetAll();
            InventoryListViewModel model = new InventoryListViewModel
            {
                Inventories = inventories
            };
            return View(model);
        }
    }
}
