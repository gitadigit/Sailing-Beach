using Microsoft.AspNetCore.Mvc;
using Sailing.Core.Services;
using SAILING_BEACH;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sailing.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatDriverController : ControllerBase
    {

        private readonly IBoatDriverService _boatDriverService;

        public BoatDriverController(IBoatDriverService boatDriverService)
        {
            _boatDriverService = boatDriverService;
        }


        // GET: api/<DriverController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_boatDriverService.GetBoatDrivers());
        }

        // GET api/<DriverController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var boatDriverId = _boatDriverService.GetByIdBoatDriver(id);
            if(boatDriverId is null)
                return NotFound();
            return Ok(boatDriverId);
        }

        // POST api/<DriverController>
        [HttpPost]
        public BoatDriver Post([FromBody] BoatDriver value)
        {
           return _boatDriverService.AddBoatDriver(value);
        }

        // PUT api/<DriverController>/5
        [HttpPut("{id}")]
        public BoatDriver Put(int id, [FromBody] BoatDriver value)
        {
           return _boatDriverService.UpdateBoatDriver(id,  value);   
        }

        // DELETE api/<DriverController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _boatDriverService.DeleteBoatDriver(id);
        }
    }
}
