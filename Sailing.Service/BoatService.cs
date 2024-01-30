using Sailing.Core.Repositoies;
using Sailing.Core.Services;
using SAILING_BEACH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailing.Service
{
    public class BoatService : IBoatService
    {

        private readonly IBoatRepository _boatRepository;

        public BoatService(IBoatRepository boatRepository)
        {
            _boatRepository = boatRepository;   
        }

        public List<Boat> GetBoats()
        {
            return _boatRepository.GetBoats();
        }

        public Boat GetByIdBoat(int id)
        {
            return _boatRepository.GetByIdBoat(id);
        }

        public Boat AddBoat(Boat boat)
        {
            return _boatRepository.AddBoat(boat);
        }

        public Boat UpdateBoat(int id, Boat boat)
        {
            return _boatRepository.UpdateBoat(id, boat);
        }

        public void DeleteBoat(int id)
        {
            _boatRepository.DeleteBoat(id);
        }

    }
}
