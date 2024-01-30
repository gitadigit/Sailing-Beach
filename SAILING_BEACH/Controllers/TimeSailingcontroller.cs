using Microsoft.AspNetCore.Mvc;
using Sailing.Core.Services;
using SAILING_BEACH;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sailing.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeSailingcontroller : ControllerBase
    {

        private readonly ISailingTimeService _sailingTimeService;

        public TimeSailingcontroller(ISailingTimeService sailingTimeService)
        {
           _sailingTimeService = sailingTimeService;
        }


        // GET: api/<TimeSailingcontroller>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_sailingTimeService.GetSailingTimes());
        }

        // GET api/<TimeSailingcontroller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var sailingTimeId = _sailingTimeService.GetByIdSailingTime(id);
            if(sailingTimeId is null)
                return NotFound();
            return Ok(sailingTimeId);
        }

        // POST api/<TimeSailingcontroller>
        [HttpPost]
        public SailingTime Post([FromBody] SailingTime value)
        {
           return _sailingTimeService.AddSailingTime(value);
        }

        // PUT api/<TimeSailingcontroller>/5
        [HttpPut("{id}")]
        public SailingTime Put(int id, [FromBody] SailingTime value)
        {
            return _sailingTimeService.UpdateSailingTime(id, value);   
        }

        // DELETE api/<TimeSailingcontroller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _sailingTimeService.DeleteSailingTime(id);
        }
    }
}
