using Solution.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Solution.MhfzDB.Entities.Concrete
{
    [Table("Employees")]
    public class Employee:IEntity
    {
        
        [Key]
        public int Employee_Id { get; set; }
        public string Name_Surname { get; set; }
        public int Santiye_Id { get; set; }
        public int Puan { get; set; }
        public float Takilmayan_Sure { get; set; }
    }
}
