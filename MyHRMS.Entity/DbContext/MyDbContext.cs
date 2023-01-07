using Microsoft.EntityFrameworkCore;
using MyHRMS.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHRMS.Entity.MyDbContext
{
    public class MyDbContext : DbContext
    {
        public DbSet<EmployeeMaster> MasterEmployees { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=DESKTOP-ECIDHC4\\SQL2019;Database=HRMS;User ID=sa;Password=Admin1234;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
