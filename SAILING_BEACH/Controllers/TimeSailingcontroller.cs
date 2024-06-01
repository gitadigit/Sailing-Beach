using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sailing.Api.Models;
using Sailing.Core;
using Sailing.Core.DTOs;
using Sailing.Core.Service;
using Sailing.Service;
using SAILING_BEACH;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sailing.Api.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class TimeSailingcontroller : ControllerBase
    {
        private readonly ISalingTimeService _timeService;
        private readonly IMapper _mapper;
        // private readonly Mapping _mapping;
        public TimeSailingcontroller(ISalingTimeService timeService, IMapper mapper)
        {
            _timeService = timeService;
            _mapper = mapper;       
        }

        // GET: api/<TimeSailingcontroller>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var SailingTime = _timeService.GetSailingTimeAsync();

            var SailingTimeDto=_mapper.Map<List<SailingTimeDto>>(SailingTime);
         
            return Ok(SailingTimeDto);
        }

        // GET api/<TimeSailingcontroller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var getIdTask = await _timeService.GetSailingTimeByIdAsync(id);
         
            var getIdDto = _mapper.Map<SailingTimeDto>(getIdTask);
           
            return Ok(getIdDto);
        }

        // POST api/<TimeSailingcontroller>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] SailingTime sailingTime)
        {
            var addSailingTime = await _timeService.AddSailingTimeAsync(sailingTime);

            var addSailingTimeDto = _mapper.Map<SailingTimeDto>(addSailingTime);

            return Ok(addSailingTimeDto);
        }

        // PUT api/<TimeSailingcontroller>/5
        [HttpPut("{id}")]
        public async Task<ActionResult >Put(int id, [FromBody] SailingTime sailingTime)
        {
            var UPdatesailingTime = await _timeService.UpdateSailingTimeAsync(id, sailingTime);

            var UPdateSailingTimerDto = _mapper.Map<SailingTimeDto>(UPdatesailingTime);

            return Ok(UPdateSailingTimerDto);


           
        }
        // DELETE api/<TimeSailingcontroller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _timeService.DeleteSailingTime(id);
        }
    }
}
