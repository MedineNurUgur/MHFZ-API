using Solution.Core.DataAccess;
using Solution.MhfzDB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.MhfzDB.DataAccess.Abstract
{
    public interface IEmployeeDal:IEntityRepository<Employee>
    {
        //custom operations
    }
}
