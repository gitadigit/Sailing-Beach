using Microsoft.AspNetCore.Mvc;
using Sailing.Core.Services;
using SAILING_BEACH;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sailing.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {

        private readonly IBoatService _boatService;

        public BoatController(IBoatService boatService)
        {
                _boatService = boatService;
        }


        // GET: api/<BoatController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_boatService.GetBoats());
        }

        // GET api/<BoatController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var boatId = _boatService.GetByIdBoat(id);
            if(boatId is null)
                return NotFound();
            return Ok(boatId);
        }

        // POST api/<BoatController>
        [HttpPost]
        public Boat Post([FromBody] Boat value)
        {
           return _boatService.AddBoat(value);
        }

        // PUT api/<BoatController>/5
        [HttpPut("{id}")]
        public Boat Put(int id, [FromBody] Boat value)
        {
           return _boatService.UpdateBoat(id, value);
        }

        // DELETE api/<BoatController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _boatService.DeleteBoat(id);    
        }
    }
}
