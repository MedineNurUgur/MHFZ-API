using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solution.MhfzDB.Business.Abstract;
using Solution.MhfzDB.Entities.Concrete;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private IInventoryService _inventoryService;
        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }
        [HttpGet]
        public IEnumerable<Inventory> Get()
        {
            return _inventoryService.GetAll();
        }
        [HttpGet("{id}")]
        public List<Inventory> Get(int id)
        {
            return _inventoryService.GetById(id);
        }
        [HttpPost]
        public IActionResult Post(Inventory inventory)
        {
            try
            {
                int result = _inventoryService.Add(inventory);
                if (result == 1)
                    return StatusCode(201, inventory);
                else
                    return StatusCode(404, "veri kaydedilemedi.");
            }
            catch (Exception ex)
            {

                return StatusCode(404, ex);
            }
        }
        [HttpPut]
        public IActionResult Put(Inventory inventory)
        {
            try
            {
                int result = _inventoryService.Update(inventory);
                if (result == 1)
                    return StatusCode(201, inventory);
                else
                    return StatusCode(404, "veri güncellenemedi.");
            }
            catch (Exception ex)
            {

                return StatusCode(404, ex);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                int result = _inventoryService.Delete(id);
                if (result == 1)
                    return StatusCode(200, id);
                else
                    return StatusCode(404, "veri silinemedi.");
            }
            catch (Exception ex)
            {

                return StatusCode(404, ex);
            }
        }
    }
}