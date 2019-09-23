using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solution.MhfzDB.Business.Abstract;
using Solution.MhfzDB.Entities.Concrete;




namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorksiteController : ControllerBase
    {
        private IWorksiteService _worksiteService;
        public WorksiteController(IWorksiteService worksiteService)
        {
            _worksiteService = worksiteService;
        }
        [HttpGet]
        public IEnumerable<Worksite> Get()
        {
            return _worksiteService.GetAll();
        }
        [HttpGet("{id}")]
        public List<Worksite> Get(int id)
        {
            return _worksiteService.GetById(id);
        }
        [HttpPost]
        public IActionResult Post(Worksite worksite)
        {
            try
            {
                int result = _worksiteService.Add(worksite);
                if (result == 1)
                    return StatusCode(201, worksite);
                else
                    return StatusCode(404, "veri kaydedilemedi.");
            }
            catch (Exception ex)
            {

                return StatusCode(404, ex);
            }

        }
        [HttpPut]
        public IActionResult Put(Worksite worksite)
        {
            try
            {
                int result = _worksiteService.Update(worksite);
                if (result == 1)
                    return StatusCode(201, worksite);
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
                int result = _worksiteService.Delete(id);
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