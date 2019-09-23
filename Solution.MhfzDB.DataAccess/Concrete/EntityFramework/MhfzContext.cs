using Microsoft.EntityFrameworkCore;
using Solution.MhfzDB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.MhfzDB.DataAccess.Concrete.EntityFramework
{
    public class MhfzContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=sql.poseidon.domainhizmetleri.com;Initial Catalog=abayakad_radin;User ID=abayakad_radin;Password=deploy123!");
        }
            
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Inventory_State> Inventory_States { get; set; }
        public DbSet<Worksite> Worksites { get; set; }
    }
}
