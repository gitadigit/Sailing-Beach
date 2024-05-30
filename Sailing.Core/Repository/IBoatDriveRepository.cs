using SAILING_BEACH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailing.Core.Repository
{
    public interface IBoatDriveRepository
    {
        List<BoatDriver>GetBoatDrivers(); 
        
        Task<BoatDriver> GetBoatDriverById(int id);

        Task<BoatDriver> AddBoatDriver(BoatDriver boatDriver);

        Task<BoatDriver> UpdateBoatDriver(int id, BoatDriver boatDriver);

        void DeleteBoatDriver(int id);


    }
}
