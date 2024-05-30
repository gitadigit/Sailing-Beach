using Sailing.Core.Repository;
using Sailing.Core.Service;
using SAILING_BEACH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailing.Service
{
    public class SalingTimeService : ISalingTimeService
    {

        private readonly ISailingTimeRepository _repository;
        public SalingTimeService(ISailingTimeRepository repository)
        {
            _repository = repository;
        }

        public List<SailingTime> GetSailingTimeAsync()
        {
            return _repository.GetSailingTime();
        }

        public async Task<SailingTime> GetSailingTimeByIdAsync(int id)
        {
            return await _repository.GetSailingTimeById(id);
        }

        public async Task<SailingTime> AddSailingTimeAsync(SailingTime sailingTime)
        {
            return await _repository.AddSailingTime(sailingTime);
        }

        public async Task<SailingTime> UpdateSailingTimeAsync(int id, SailingTime sailingTime)
        {
            return await _repository.UpdateSailingTime(id, sailingTime);
        }

        public void DeleteSailingTime(int id)
        {
            _repository.DeleteSailingTime(id);
        }

        
        
    }
}
