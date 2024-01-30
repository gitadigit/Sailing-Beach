using Sailing.Core.Repositoies;
using SAILING_BEACH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailing.Data.Repositories
{
    public class BoatRepository : IBoatRepository
    {
        private readonly DataContext _context;

        public BoatRepository(DataContext context)
        {
            _context = context;
        }

        public List<Boat> GetBoats()
        {
            return _context.boats.ToList();
        }

        public Boat GetByIdBoat(int id)
        {
            return _context.boats.Find(id);
        }

        public Boat AddBoat(Boat boat)
        {
            _context.boats.Add(boat);
            _context.SaveChanges();
            return boat;
        }

        public Boat UpdateBoat(int id, Boat boat)
        {
           var updateBoat=GetByIdBoat(id);

            updateBoat.YearOfManufacture=boat.YearOfManufacture;    
            updateBoat.NumberOfPassenger=boat.NumberOfPassenger;
            updateBoat.AfterSunset=boat.AfterSunset;
            updateBoat.CompanyName = boat.CompanyName;

            return updateBoat;  
        }

        public void DeleteBoat(int id)
        {
            _context.boats.Remove(_context.boats.Find(id));
            _context.SaveChanges();
        }

    }
}
