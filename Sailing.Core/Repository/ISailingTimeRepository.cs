using SAILING_BEACH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailing.Core.Repository
{
    public interface ISailingTimeRepository
    {
        List<SailingTime> GetSailingTime();

        Task<SailingTime> GetSailingTimeById(int id);

        Task<SailingTime> AddSailingTime(SailingTime sailingtime);

        Task<SailingTime> UpdateSailingTime(int id, SailingTime sailingTime);

      
        void DeleteSailingTime(int id);
    }
}
