using Solution.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Solution.MhfzDB.Entities.Concrete
{
    [Table("Experts")]
    public class Expert:IEntity
    {
        [Key]
        public int Expert_Id { get; set; }
        public string Name_Surname { get; set; }
    }
}
