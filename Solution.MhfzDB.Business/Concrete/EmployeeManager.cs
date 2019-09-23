using Solution.MhfzDB.Business.Abstract;
using Solution.MhfzDB.DataAccess.Abstract;
using Solution.MhfzDB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.MhfzDB.Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }
        public int Add(Employee employee)
        {
           return _employeeDal.Add(employee);
        }

        public int Delete(int id)
        {
           return _employeeDal.Delete(new Employee { Employee_Id = id });
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetList();
        }

        public List<Employee> GetById(int id)
        {
            return _employeeDal.GetList(p => p.Employee_Id == id);
        }

        public int Update(Employee employee)
        {
            return _employeeDal.Update(employee);
        }
    }
}
