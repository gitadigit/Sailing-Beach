using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SAILING_BEACH;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailing.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Boat> boats { get; set; }

        public DbSet<BoatDriver> boatDrivers { get; set; }

        public DbSet<SailingTime> sailingTimes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=adiSalingBeach_db");
        }

        public DataContext() { }


    }

}
