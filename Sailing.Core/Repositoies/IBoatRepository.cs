using SAILING_BEACH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailing.Core.Repositoies
{
    public interface IBoatRepository
    {
        List<Boat> GetBoats();

        Boat GetByIdBoat(int id);

        Boat AddBoat(Boat boat);    

        Boat UpdateBoat(int id,Boat boat);

        void DeleteBoat(int id);

    }
}
