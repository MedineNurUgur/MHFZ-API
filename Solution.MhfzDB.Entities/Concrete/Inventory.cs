using Solution.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Solution.MhfzDB.Entities.Concrete
{
    [Table("Inventories")]
    public class Inventory:IEntity
    {
        [Key]
        public int Inventory_Id { get; set; }
        public string Inventory_Type { get; set; }
        public int Employee_Id { get; set; }
    }
}
