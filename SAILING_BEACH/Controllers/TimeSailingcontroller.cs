using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sailing.Api.Models;
using Sailing.Core;
using Sailing.Core.DTOs;
using Sailing.Core.Service;
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
            var getTask = _timeService.GetSailingTimeAsync();
            var timeDto=_mapper.Map<List<SailingTimeDto>>(getTask);
            //await Task.WhenAll(getTask);
            //var timeDto=new List<SailingTimeDto>();
            //foreach(var t in time)
            //{
            //    timeDto.Add(_mapper.Map<SailingTimeDto>(t));
            //   // timeDto.Add(_mapping.MapToSailingTimeDto(t));
            //}
            return Ok(timeDto);//getTask
        }

        // GET api/<TimeSailingcontroller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var getIdTask = await _timeService.GetSailingTimeByIdAsync(id);
            // var timeDto=_mapping.MapToSailingTimeDto(time);
            var timeDto = _mapper.Map<SailingTimeDto>(getIdTask);
            //var timeDto=new SailingTimeDto { EndTime = time.EndTime , StartTime=time.StartTime };
            return Ok(timeDto);
        }

        // POST api/<TimeSailingcontroller>
        [HttpPost]
        public async Task<SailingTime> Post([FromBody] SailingTimePostModel sailingTime)
        {
            var timeToAdd=  new SailingTime {StartTime=sailingTime.StartTime, EndTime=sailingTime.EndTime};  
            return await _timeService.AddSailingTimeAsync(timeToAdd);
        }

        // PUT api/<TimeSailingcontroller>/5
        [HttpPut("{id}")]
        public async Task<SailingTime >Put(int id, [FromBody] SailingTimePostModel sailingTime)
        {
            var timeToAdd= new SailingTime {StartTime=sailingTime.StartTime, EndTime=sailingTime.EndTime};
            return await _timeService.UpdateSailingTimeAsync(id, timeToAdd);

        }

        // DELETE api/<TimeSailingcontroller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _timeService.DeleteSailingTime(id);
        }
    }
}
