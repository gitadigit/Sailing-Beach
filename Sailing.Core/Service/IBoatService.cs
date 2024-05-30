using SAILING_BEACH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailing.Core.Service
{
    public interface IBoatService
    {
       List<Boat> GetBoatAsync();

        Task<Boat> GetBoatByIdAsync(int id);

        Task<Boat> AddBoatAsync(Boat boat);

        Task<Boat> UpdateBoatAsync(int id, Boat boatDriver);

        void DeleteBoatAsync(int id);
    }
}
