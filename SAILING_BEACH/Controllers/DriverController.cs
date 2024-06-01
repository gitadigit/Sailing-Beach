using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sailing.Core.DTOs;
using Sailing.Core.Service;
using SAILING_BEACH;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sailing.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IBoatDriverService _boatDriverService;

        private readonly IMapper _mapper;   

        public DriverController(IBoatDriverService boatDriverService, IMapper mapper)
        {
            _boatDriverService = boatDriverService;
            _mapper = mapper;   
        }

        // GET: api/<DriverController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var getTask = _boatDriverService.GetBoatDriversAsync();
            var getDto =  _mapper.Map<List<BoatDriverDto>>(getTask);
            return Ok(getDto);
        }

        // GET api/<DriverController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var getIdTask = await _boatDriverService.GetBoatDriverByIdAsync(id);
            var getIdDto =  _mapper.Map<BoatDriverDto>(getIdTask);
            return Ok(getIdTask);
        }

        // POST api/<DriverController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] BoatDriver boatDriver)
        {
            var boatDriverTask = await _boatDriverService.AddBoatDriverAsync(boatDriver);
            var boatDriverDto =  _mapper.Map<BoatDriverDto>(boatDriverTask);
            return Ok(boatDriverDto);
        }

        // PUT api/<DriverController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] BoatDriver boatDriver)
        {
            var addBoatDriverTask = await _boatDriverService.UpdateBoatDriverAsync(id, boatDriver);
            var addBoatDriverDto =  _mapper.Map<BoatDriverDto>(addBoatDriverTask);
            return Ok(addBoatDriverDto);
        }








        // DELETE api/<DriverController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _boatDriverService.DeleteBoatDriver(id);
        }
    }
}
