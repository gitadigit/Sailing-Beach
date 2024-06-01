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
    public class BoatController : ControllerBase
    {
        private readonly IBoatService _boatService;

        private readonly IMapper _mapper;

        public BoatController(IBoatService boatService, IMapper mapper)
        {
            _boatService = boatService;
            _mapper = mapper;
        }

        // GET: api/<BoatController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var getTask = _boatService.GetBoatAsync();
            var getDto = _mapper.Map<List<BoatDto>>(getTask);
            return Ok(getDto);
        }

        // GET api/<BoatController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var getIdTask = await _boatService.GetBoatByIdAsync(id);
            var boatDto= _mapper.Map<BoatDto>(getIdTask);
            return Ok(boatDto);
        }

        // POST api/<BoatController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Boat boat)
        {
            var boatTask= await _boatService.AddBoatAsync(boat);
            var boatDto=_mapper.Map<BoatDto>(boatTask);
            return Ok(boatDto);
        }

        // PUT api/<BoatController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Boat boat)
        {
            var addBoat = await _boatService.UpdateBoatAsync(id, boat);
            var addBoaDto = _mapper.Map<BoatDto>(addBoat);
            return Ok(addBoaDto);
        }

        // DELETE api/<BoatController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
           _boatService.DeleteBoatAsync(id);
        }
    }
}
