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
    public class BoatDriverService : IBoatDriverService
    {

        private readonly IBoatDravierRepository _boatDravierRepository; 

        public BoatDriverService(IBoatDravierRepository boatDravierRepository)
        {
            _boatDravierRepository = boatDravierRepository;
        }   

        public List<BoatDriver> GetBoatDrivers()
        {
            return _boatDravierRepository.GetBoatDrivers();
        }

        public BoatDriver GetByIdBoatDriver(int id)
        {
            return _boatDravierRepository.GetByIdBoatDriver(id);
        }

        public BoatDriver AddBoatDriver(BoatDriver boatDriver)
        {
            return _boatDravierRepository.AddBoatDriver(boatDriver);
        }
        public BoatDriver UpdateBoatDriver(int id, BoatDriver boatDriver)
        {
            return _boatDravierRepository.UpdateBoatDriver(id, boatDriver);
        }

        public void DeleteBoatDriver(int id)
        {
            _boatDravierRepository.DeleteBoatDriver(id);
        }
    }
}
