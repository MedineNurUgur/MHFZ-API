using Solution.MhfzDB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.MhfzDB.Business.Abstract
{
    public interface IExpertService
    {
        List<Expert> GetAll();
        List<Expert> GetById(int id);
        int Add(Expert expert);
        int Update(Expert expert);
        int Delete(int id);
    }
}
