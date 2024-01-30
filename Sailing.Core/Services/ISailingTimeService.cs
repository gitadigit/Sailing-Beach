using SAILING_BEACH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailing.Core.Services
{
    public interface ISailingTimeService
    {
        List<SailingTime> GetSailingTimes();

        SailingTime GetByIdSailingTime(int id);

        SailingTime AddSailingTime(SailingTime sailingTime);

        SailingTime UpdateSailingTime(int id, SailingTime sailingTime);

        void DeleteSailingTime(int id);
    }
}
