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
    public class BoatDriverService : IBoatDriverService
    {

        private readonly IBoatDriveRepository _boatDriveRepository;
        public BoatDriverService(IBoatDriveRepository boatDriveRepository)
        {
            _boatDriveRepository = boatDriveRepository;
        }

        public List<BoatDriver> GetBoatDriversAsync()
        {
            return _boatDriveRepository.GetBoatDrivers();
        }
        public  async Task<BoatDriver> GetBoatDriverByIdAsync(int id)
        {
            return await _boatDriveRepository.GetBoatDriverById(id);
        }

        public async Task<BoatDriver> AddBoatDriverAsync(BoatDriver boatDriver)
        {
           return await _boatDriveRepository.AddBoatDriver(boatDriver);
        }

        public async Task<BoatDriver> UpdateBoatDriverAsync(int id, BoatDriver boatDriver)
        {
            return await _boatDriveRepository.UpdateBoatDriver(id, boatDriver);
        }

        public void DeleteBoatDriver(int id)
        {
            _boatDriveRepository.DeleteBoatDriver(id);

        }


    }
}
