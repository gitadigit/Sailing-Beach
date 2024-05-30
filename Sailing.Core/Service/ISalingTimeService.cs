using SAILING_BEACH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailing.Core.Service
{
    public interface ISalingTimeService
    {
        List<SailingTime> GetSailingTimeAsync();

        Task<SailingTime >GetSailingTimeByIdAsync(int id);

        Task<SailingTime> AddSailingTimeAsync(SailingTime sailingTime);

        Task<SailingTime> UpdateSailingTimeAsync(int id, SailingTime sailingTime);

        void DeleteSailingTime(int id);
    }
}
