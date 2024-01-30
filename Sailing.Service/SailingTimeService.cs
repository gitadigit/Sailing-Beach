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
    public class SailingTimeService : ISailingTimeService
    {

        private readonly ISailingTimeRepository _sailingTimeRepository;

        public SailingTimeService(ISailingTimeRepository sailingTimeRepository)
        {
            this._sailingTimeRepository = sailingTimeRepository;
        }

        public List<SailingTime> GetSailingTimes()
        {
            return _sailingTimeRepository.GetSailingTimes();
        }

        public SailingTime GetByIdSailingTime(int id)
        {
            return _sailingTimeRepository.GetByIdSailingTime(id);
        }

        public SailingTime AddSailingTime(SailingTime sailingTime)
        {
            return _sailingTimeRepository.AddSailingTime(sailingTime);
        }

        public SailingTime UpdateSailingTime(int id, SailingTime sailingTime)
        {
            return _sailingTimeRepository.UpdateSailingTime(id, sailingTime);
        }

        public void DeleteSailingTime(int id)
        {
            _sailingTimeRepository.DeleteSailingTime(id);
        }
    }
}
