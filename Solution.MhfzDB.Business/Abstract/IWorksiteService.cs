using Solution.MhfzDB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.MhfzDB.Business.Abstract
{
    public interface IWorksiteService
    {
        List<Worksite> GetAll();
        List<Worksite> GetById(int id);
        int Add(Worksite worksite);
        int Update(Worksite worksite);
        int Delete(int id);
    }
}
