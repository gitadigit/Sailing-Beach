using Microsoft.EntityFrameworkCore;
using SAILING_BEACH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailing.Data
{
    public class Context:DbContext
    {

        public DbSet<BoatDriver> BoatDrivers { get; set; }
        public DbSet<Boat>Boats { get; set; }
        public DbSet<SailingTime> SailingTime { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SailingBoatDB");
        }
    }
}
