using Solution.MhfzDB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.MhfzDB.Business.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        List<Employee> GetById(int id);
        int Add(Employee employee);
        int Update(Employee employee);
        int Delete(int id);
    }
}
