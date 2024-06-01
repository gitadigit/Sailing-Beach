using Microsoft.EntityFrameworkCore;
using Sailing.Core.Repository;
using SAILING_BEACH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailing.Data.Repository
{
    public class TimeSailingRepository : ISailingTimeRepository
    {

        private readonly Context _context;
        public TimeSailingRepository(Context context)
        {
            _context = context;
        }

        public List<SailingTime> GetSailingTime()
        {
            return _context.SailingTime.ToList();
        }

        public  async Task<SailingTime> GetSailingTimeById(int id)
        {
            var sailingTime = _context.SailingTime.Find(id);
            await _context.SaveChangesAsync();
            return sailingTime;
        }

        public async Task<SailingTime> AddSailingTime(SailingTime sailingTime)
        {
            _context.SailingTime.Add(sailingTime);
            await _context.SaveChangesAsync();

            return sailingTime;
            
        }

        public async Task<SailingTime> UpdateSailingTime(int id, SailingTime sailingTime1)
        {
            var sailingtime=_context.SailingTime.Find(id);
            sailingtime.StartTime = sailingTime1.StartTime;
            sailingtime.EndTime = sailingTime1.EndTime;
            sailingtime.Boat=sailingTime1.Boat;
            sailingtime.BoatDriver=sailingTime1.BoatDriver;

            await _context.SaveChangesAsync();
            return sailingtime;
        }

        public void DeleteSailingTime(int id)
        {
            _context.SailingTime.Remove(_context.SailingTime.Find(id));
             _context.SaveChanges();
        }
    }
}
