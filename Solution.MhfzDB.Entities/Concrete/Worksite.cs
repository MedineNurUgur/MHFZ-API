using Solution.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Solution.MhfzDB.Entities.Concrete
{
    [Table("Worksites")]
    public class Worksite:IEntity
    {
        [Key]
        public int Worksite_Id { get; set; }
        public int Expert_Id { get; set; }
        public float Shift { get; set; }
        public int Company_Id { get; set; }
    }
}
