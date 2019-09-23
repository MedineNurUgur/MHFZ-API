using Solution.MhfzDB.Business.Abstract;
using Solution.MhfzDB.DataAccess.Abstract;
using Solution.MhfzDB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.MhfzDB.Business.Concrete
{
    public class WorksiteManager:IWorksiteService
    {
        private IWorksiteDal _worksiteDal;
        public WorksiteManager(IWorksiteDal worksiteDal)
        {
            _worksiteDal = worksiteDal;
        }
        public int Add(Worksite worksite)
        {
            return _worksiteDal.Add(worksite);
        }

        public int Delete(int id)
        {
            return _worksiteDal.Delete(new Worksite{ Worksite_Id = id });
        }

        public List<Worksite> GetAll()
        {
            return _worksiteDal.GetList();
        }

        public List<Worksite> GetById(int id)
        {
            return _worksiteDal.GetList(p => p.Worksite_Id == id);
        }

        public int Update(Worksite worksite)
        {
            return _worksiteDal.Update(worksite);
        }
    }
}
