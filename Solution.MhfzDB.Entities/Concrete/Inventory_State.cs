using Solution.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Solution.MhfzDB.Entities.Concrete
{
    [Table("Inventory_States")]
    public class Inventory_State:IEntity
    {
        [Key]
        public int Inventory_Id { get; set; }
        public int State { get; set; }
    }
}
