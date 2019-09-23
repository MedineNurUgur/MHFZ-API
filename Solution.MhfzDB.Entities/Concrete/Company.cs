using Solution.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Solution.MhfzDB.Entities.Concrete
{
    [Table("Companies")]
    public class Company:IEntity
    {
        [Key]
        public int Company_Id { get; set; }
        public string Company_Name { get; set; }
    }
}
