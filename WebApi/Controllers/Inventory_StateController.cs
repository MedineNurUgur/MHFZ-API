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
    public class Inventory_StateController : ControllerBase
    {
        private IInventory_StateService _inventory_stateService;
        public Inventory_StateController(IInventory_StateService inventory_stateService)
        {
            _inventory_stateService = inventory_stateService;
        }
        [HttpGet]
        public IEnumerable<Inventory_State> Get()
        {
            return _inventory_stateService.GetAll();
        }
        [HttpGet("{id}")]
        public List<Inventory_State> Get(int id)
        {
            return _inventory_stateService.GetById(id);
        }
        [HttpPost]
        public IActionResult Post(Inventory_State inventoryState)
        {
            try
            {
                int result = _inventory_stateService.Add(inventoryState);
                if (result == 1)
                    return StatusCode(201, inventoryState);
                else
                    return StatusCode(404, "veri kaydedilemedi.");
            }
            catch (Exception ex)
            {

                return StatusCode(404, ex);
            }
        }
        [HttpPut]
        public IActionResult Put(Inventory_State inventoryState)
        {
            try
            {
                int result = _inventory_stateService.Update(inventoryState);
                if (result == 1)
                    return StatusCode(201, inventoryState);
                else
                    return StatusCode(404, "veri güncellenmedi.");
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
                int result = _inventory_stateService.Delete(id);
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