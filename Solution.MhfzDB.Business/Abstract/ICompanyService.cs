using Solution.MhfzDB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.MhfzDB.Business.Abstract
{
    public interface ICompanyService
    {
        List<Company> GetAll();
        List<Company> GetById(int id);
        int Add(Company company);
        int Update(Company company);
        int Delete(int id);
    }
}
