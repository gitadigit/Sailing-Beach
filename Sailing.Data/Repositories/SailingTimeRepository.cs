using Microsoft.EntityFrameworkCore;
using Sailing.Core.Repositoies;
using SAILING_BEACH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailing.Data.Repositories
{
    public class SailingTimeRepository : ISailingTimeRepository
    {
        private readonly DataContext _context;

        public SailingTimeRepository(DataContext context)
        {
            _context = context;
        }
        public List<SailingTime> GetSailingTimes()
        {
            return _context.sailingTimes.Include(b => b.BoatDrivers).ToList();
        }

        public SailingTime GetByIdSailingTime(int id)
        {
            return _context.sailingTimes.Find(id);
        }

        public SailingTime AddSailingTime( SailingTime sailingTime)
        {
            _context.sailingTimes.Add(sailingTime);
            _context.SaveChanges();
            return sailingTime;
        }

        public SailingTime UpdateSailingTime(int id, SailingTime sailingTime)
        {
            var updateSailingTime = GetByIdSailingTime(id);

            updateSailingTime.StartTime = sailingTime.StartTime;
            updateSailingTime.EndTime = sailingTime.EndTime;

            return updateSailingTime;
        }

        public void DeleteSailingTime(int id)
        {
           _context.sailingTimes.Remove(_context.sailingTimes.Find(id));
            _context.SaveChanges();
        }

    }
}
