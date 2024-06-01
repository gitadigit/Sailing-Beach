using Sailing.Core.Repository;
using Sailing.Core.Service;
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

        public List<Boat> GetBoatAsync()
        {
            return _boatRepository.GetBoat();
        }

        public async Task<Boat> GetBoatByIdAsync(int id)
        {
            return await _boatRepository.GetBoatById(id);
        }

        public async Task<Boat> AddBoatAsync(Boat boat)
        {
            return await _boatRepository.AddBoat(boat);
        }

        public async Task<Boat> UpdateBoatAsync(int id, Boat boat)
        {
            return await _boatRepository.UpdateBoat(id, boat);
        }

        public void DeleteBoatAsync(int id)
        {
            _boatRepository.DeleteBoat(id);
        }
    }
}
