using Solution.MhfzDB.Business.Abstract;
using Solution.MhfzDB.DataAccess.Abstract;
using Solution.MhfzDB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.MhfzDB.Business.Concrete
{
    public class ExpertManager : IExpertService
    {
        private IExpertDal _expertDal;
        public ExpertManager(IExpertDal expertDal)
        {
            _expertDal = expertDal;
        }
        public int Add(Expert expert)
        {
            return _expertDal.Add(expert);
        }

        public int Delete(int id)
        {
            return _expertDal.Delete(new Expert { Expert_Id = id });
        }

        public List<Expert> GetAll()
        {
            return _expertDal.GetList();
        }

        public List<Expert> GetById(int id)
        {
            return _expertDal.GetList(p => p.Expert_Id == id);
        }

        public int Update(Expert expert)
        {
            return _expertDal.Update(expert);
        }
    }
}
