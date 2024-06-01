using Sailing.Core.Repository;
using SAILING_BEACH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailing.Data.Repository
{
    public class BoatRepository : IBoatRepository
    {

        private readonly Context _context;
        public BoatRepository(Context context)
        {
            _context = context;
        }

        public  List<Boat> GetBoat()
        {
            return  _context.Boats.ToList();
        }

        public async Task<Boat> GetBoatById(int id)
        {
            var result = _context.Boats.Find(id);
           await _context.SaveChangesAsync();
            return result;
        }

        public async Task<Boat> AddBoat(Boat boat)
        {
            _context.Boats.Add(boat);
            await _context.SaveChangesAsync();
            return boat;
        }

        public async Task<Boat> UpdateBoat(int id, Boat boatDriver)
        {
            var boat = _context.Boats.Find(id);
            boat.YearOfManufacture = boatDriver.YearOfManufacture;
            boat.NumberOfPassenger = boatDriver.NumberOfPassenger;
            boat.AfterSunset = boatDriver.AfterSunset;
            boat.CompanyName = boatDriver.CompanyName;
            await _context.SaveChangesAsync();
            return boat;
        }

        public void DeleteBoat(int id)
        {
            _context.Boats.Remove(_context.Boats.Find(id));
            _context.SaveChanges();
        }

       
    }
}
