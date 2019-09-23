using Solution.MhfzDB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.MhfzDB.Business.Abstract
{
    public interface IInventory_StateService
    {
        List<Inventory_State> GetAll();
        List<Inventory_State> GetById(int id);
        int Add(Inventory_State inventory_State);
        int Update(Inventory_State inventory_State);
        int Delete(int id);
    }
}
