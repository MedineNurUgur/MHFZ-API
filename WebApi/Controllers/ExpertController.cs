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
    public class ExpertController : ControllerBase
    {
        private IExpertService _expertService;
        public ExpertController(IExpertService expertService)
        {
            _expertService = expertService;
        }
        [HttpGet]
        public IEnumerable<Expert> Get()
        {
            return _expertService.GetAll();
        }
        [HttpGet("{id}")]
        public List<Expert> Get(int id)
        {
            return _expertService.GetById(id);
        }
        [HttpPost]
        public IActionResult Post(Expert expert)
        {
            try
            {
                int result = _expertService.Add(expert);
                if (result == 1)
                    return StatusCode(201, expert);
                else
                    return StatusCode(404, "veri kaydedilemedi.");
            }
            catch (Exception ex)
            {

                return StatusCode(404, ex);
            }
        }
        [HttpPut]
        public IActionResult Put(Expert expert)
        {
            try
            {
                int result = _expertService.Update(expert);
                if (result == 1)
                    return StatusCode(201, expert);
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
                int result = _expertService.Delete(id);
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