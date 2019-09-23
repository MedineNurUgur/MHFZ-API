using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    public class CompanyController : ControllerBase
    {
        //HttpClient client = new HttpClient();
        private ICompanyService _companyService;
        public List<Company> comp;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        

        [HttpGet]
        public IActionResult Get()
        {
            comp= _companyService.GetAll();
            return Ok(comp);
        }

        [HttpGet("{id}")]
        public List<Company> Get(int id)
        {
            
            return _companyService.GetById(id);
        }

        [HttpPost]
        public IActionResult Post(Company company)
        {
            try
            {
                int result = _companyService.Add(company);
                if (result == 1)
                    return StatusCode(201, company);
                else
                    return StatusCode(404,"veri kaydedilemedi.");
            }
            catch (Exception ex)
            {

                return StatusCode(404, ex);
            }
            
            
        }

        [HttpPut]
        public IActionResult Put(Company company)
        {
            try
            {
                int result = _companyService.Update(company);
                if (result == 1)
                    return StatusCode(201, company);
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
                int result = _companyService.Delete(id);
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