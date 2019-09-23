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
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employeeService.GetAll();
        }
        [HttpGet("{id}")]
        public List<Employee> Get(int id)
        {
            return _employeeService.GetById(id);
        }
        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            try
            {
                int result = _employeeService.Add(employee);
                if (result == 1)
                    return StatusCode(201, employee);
                else
                    return StatusCode(404, "veri kaydedilemedi.");
            }
            catch (Exception ex)
            {

                return StatusCode(404, ex);
            }
        }
        [HttpPut]
        public IActionResult Put(Employee employee)
        {
            try
            {
                int result = _employeeService.Update(employee);
                if (result == 1)
                    return StatusCode(201, employee);
                else
                    return StatusCode(404, "veri kaydedilemedi.");
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
                int result = _employeeService.Delete(id);
                if (result == 1)
                    return StatusCode(200, id);
                else
                    return StatusCode(404, "veri kaydedilemedi.");
            }
            catch (Exception ex)
            {

                return StatusCode(404, ex);
            }
        }
    }
}