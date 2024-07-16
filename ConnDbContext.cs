using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co_Working_Space_Management_Application
{
    public class ConnDbContext : DbContext
    {
        public DbSet<EmployeeModel> TB_Employee { get; set; }
        public DbSet<InventoryModel> TB_Inventaris { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server = localhost; Database = BD_WorkingApplication; Trusted_Connection = True; TrustServerCertificate = True");
        }
    }
}
