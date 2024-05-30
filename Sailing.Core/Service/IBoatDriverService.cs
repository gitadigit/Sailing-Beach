using SAILING_BEACH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailing.Core.Service
{
    public interface IBoatDriverService
    {
        
        List<BoatDriver> GetBoatDriversAsync();

        Task<BoatDriver> GetBoatDriverByIdAsync(int id);

        Task<BoatDriver >AddBoatDriverAsync(BoatDriver boatDriver);

        Task<BoatDriver> UpdateBoatDriverAsync(int id, BoatDriver boatDriver);

        void DeleteBoatDriver(int id);

    }
}
