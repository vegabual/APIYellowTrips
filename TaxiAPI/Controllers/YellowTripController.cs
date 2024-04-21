using Microsoft.AspNetCore.Mvc;
using TaxiAPI.DTO;
using TaxiAPI.Entities;
using TaxiAPI.Interfaces;
using TaxiAPI.Services;

namespace TaxiAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class YellowTripController : ControllerBase
    {

        private readonly ILogger<YellowTripController> _logger;
        private readonly IYellowTripsService _yellowTripService;


        public YellowTripController(IYellowTripsService yellowTripService, ILogger<YellowTripController> logger)
        {
            _yellowTripService = yellowTripService;
            _logger = logger;
        }
        /// <summary>
        /// Gets the Yellow Taxi Trip Records for NYC in January 2024 with pagination
        /// </summary>
        /// <param name="limit">Amount of results that will be given</param>
        /// <param name="offset">Amount of results that will be stepped off</param>
        /// <param name="filter">Filter for the results</param>
        /// <returns>Yellow Taxi Trip Records for NYC in January 2024</returns>
        [HttpGet]
        public IActionResult Get(int limit = 20, int offset = 0, [FromQuery]FilterDTO filter = null)
        {
            var trips = _yellowTripService.GetYellowTripsFiltered(limit, offset, filter);
            return Ok(trips);
        }
    }
}
