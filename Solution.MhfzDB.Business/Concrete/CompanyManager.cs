using System;
using System.Collections.Generic;
using System.Text;
using Solution.MhfzDB.Business.Abstract;
using Solution.MhfzDB.DataAccess.Abstract;
using Solution.MhfzDB.Entities.Concrete;

namespace Solution.MhfzDB.Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private ICompanyDal _companyDal;
        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }
        public int Add(Company company)
        {
           return _companyDal.Add(company);
            
        }

        public int Delete(int id)
        {
            return _companyDal.Delete(new Company { Company_Id = id });
        }

        public List<Company> GetAll()
        {
            return _companyDal.GetList();
        }

        public List<Company> GetById(int id)
        {
            return _companyDal.GetList(p => p.Company_Id == id);
        }

        public int Update(Company company)
        {
            return _companyDal.Update(company);
        }
    }
}
