using Solution.MhfzDB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.MhfzDB.Business.Abstract
{
    public interface IInventoryService
    {
        List<Inventory> GetAll();
        List<Inventory> GetById(int id);
        int Add(Inventory inventory);
        int Update(Inventory inventory);
        int Delete(int id);
    }
}
