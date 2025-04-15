using Microsoft.AspNetCore.Mvc;
using scooter_api.Scooters.Dtos;
using scooter_api.Scooters.Exceptions;
using scooter_api.Scooters.Service;

namespace scooter_api.Scooters.ScooterController
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ScooterController : ControllerBase
    {
        private readonly IScooterCommandService _scooterCommandService;
        private readonly IScooterQueryService _scooterQueryService;

        public ScooterController(IScooterCommandService commandService, IScooterQueryService queryService)
        {
            _scooterCommandService = commandService;
            _scooterQueryService = queryService;
        }

        [HttpGet("all")]
        public async Task<ActionResult<List<ScooterResponse>>> GetScootersAsync()
        {
            var scooters = await _scooterQueryService.GetAllScooters();
            return Ok(scooters);
        }

        [HttpPost("addScooter")]
        public async Task<ActionResult<ScooterResponse>> AddScooterAsync([FromBody] AddScooterRequest scooterReq)
        {
            try
            {
                var result = await _scooterCommandService.AddScooter(scooterReq);
                return Created("", result);
            }
            catch (BrandExistException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("deleteScooter")]
        public async Task<ActionResult<ScooterResponse>> DeleteScooter([FromQuery] int id)
        {
            try
            {
                var result = await _scooterCommandService.DeleteScooterById(id);
                return Accepted(result);
            }
            catch (ScooterNotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("updateScooter")]
        public async Task<ActionResult<ScooterResponse>> UpdateScooter([FromQuery] int id, [FromBody] EditScooterRequest scooterReq)
        {
            try
            {
                var result = await _scooterCommandService.EditScooter(id, scooterReq);
                return Accepted(result);
            }
            catch (BrandExistException ex) { return BadRequest(ex.Message); }
            catch (ScooterNotFoundException ex) { return BadRequest(ex.Message); }
        }

        [HttpGet("getMinHP")]
        public async Task<ActionResult<List<ScooterResponse>>> GetMinHorsePower([FromQuery] int minHp)
        {
            try
            {
                var result = await _scooterCommandService.GetScootersByMinHorsePower(minHp);
                return Ok(result);
            }
            catch (ScooterNotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("getMinMaxSpeed")]
        public async Task<ActionResult<List<ScooterResponse>>> GetMinMaxSpeed([FromQuery] int minSpeed, [FromQuery] int maxSpeed)
        {
            try
            {
                var result = await _scooterCommandService.GetScootersBySpeedRange(minSpeed, maxSpeed);
                return Ok(result);
            }
            catch (ScooterNotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("getMinSpeed/{minSpeed}")]
        public async Task<ActionResult<List<ScooterResponse>>> GetScootersByMinSpeed([FromRoute] int minSpeed)
        {
            try
            {
                var result = await _scooterCommandService.GetScootersByMinSpeed(minSpeed);
                return Ok(result);
            }
            catch (ScooterNotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("getScootersByBrand/{brand}")]
        public async Task<ActionResult<List<ScooterResponse>>> GetScootersByBrand([FromRoute] string brand)
        {
            try
            {
                var result = await _scooterCommandService.GetScootersByBrand(brand);
                return Ok(result);
            }
            catch (ScooterNotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
