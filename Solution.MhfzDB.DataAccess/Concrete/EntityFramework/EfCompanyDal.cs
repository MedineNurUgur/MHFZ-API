using System;
using System.Collections.Generic;
using System.Text;
using Solution.Core.DataAccess.EntityFramework;
using Solution.MhfzDB.DataAccess.Abstract;
using Solution.MhfzDB.Entities.Concrete;

namespace Solution.MhfzDB.DataAccess.Concrete.EntityFramework
{
    public class EfCompanyDal:EfEntityRepositoryBase<Company,MhfzContext>,ICompanyDal
    {
    }
}
