using Solution.MhfzDB.Business.Abstract;
using Solution.MhfzDB.DataAccess.Abstract;
using Solution.MhfzDB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.MhfzDB.Business.Concrete
{
    public class Inventory_StateManager:IInventory_StateService
    {
        private IInventory_StateDal _inventory_StateDal;
        public Inventory_StateManager(IInventory_StateDal inventory_stateDal)
        {
            _inventory_StateDal = inventory_stateDal;
        }
        public int Add(Inventory_State inventory_State)
        {
            return _inventory_StateDal.Add(inventory_State);
        }

        public int Delete(int id)
        {
            return _inventory_StateDal.Delete(new Inventory_State { Inventory_Id = id });
        }

        public List<Inventory_State> GetAll()
        {
            return _inventory_StateDal.GetList();
        }

        public List<Inventory_State> GetById(int id)
        {
            return _inventory_StateDal.GetList(p => p.Inventory_Id == id);
        }

        public int Update(Inventory_State inventory_state)
        {
            return _inventory_StateDal.Update(inventory_state);
        }
    }
}
