using System;
using System.Collections.Generic;
using System.Text;
using Solution.Core.DataAccess;
using Solution.MhfzDB.Entities.Concrete;

namespace Solution.MhfzDB.DataAccess.Abstract
{
    public interface IInventory_StateDal:IEntityRepository<Inventory_State>
    {
    }
}
