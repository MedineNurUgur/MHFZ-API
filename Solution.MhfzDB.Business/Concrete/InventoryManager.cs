using Solution.MhfzDB.Business.Abstract;
using Solution.MhfzDB.DataAccess.Abstract;
using Solution.MhfzDB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.MhfzDB.Business.Concrete
{
    public class InventoryManager:IInventoryService
    {
        private IInventoryDal _inventoryDal;
        public InventoryManager(IInventoryDal inventoryDal)
        {
            _inventoryDal = inventoryDal;
        }
        public int Add(Inventory inventory)
        {
            return _inventoryDal.Add(inventory);
        }

        public int Delete(int id)
        {
            return _inventoryDal.Delete(new Inventory { Inventory_Id = id });
        }

        public List<Inventory> GetAll()
        {
            return _inventoryDal.GetList();
        }

        public List<Inventory> GetById(int id)
        {
            return _inventoryDal.GetList(p => p.Inventory_Id == id);
        }

        public int Update(Inventory inventory)
        {
            return _inventoryDal.Update(inventory);
        }
    }
}
