using SAILING_BEACH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailing.Core.Repository
{
    public interface IBoatRepository
    {
        List<Boat> GetBoat();

        Task<Boat> GetBoatById(int id);

        Task<Boat> AddBoat(Boat boat);

        Task<Boat> UpdateBoat(int id, Boat boatDriver);

        void DeleteBoat(int id);

    }
}
