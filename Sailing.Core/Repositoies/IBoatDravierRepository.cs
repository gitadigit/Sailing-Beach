using SAILING_BEACH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailing.Core.Repositoies
{
    public interface IBoatDravierRepository
    {
        List<BoatDriver> GetBoatDrivers();

        BoatDriver GetByIdBoatDriver(int id);

        BoatDriver AddBoatDriver(BoatDriver boatDriver);

        BoatDriver UpdateBoatDriver(int id,BoatDriver boatDriver);

        void DeleteBoatDriver(int id);

    }
}
