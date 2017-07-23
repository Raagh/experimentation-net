using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {

        [HttpGet()]
        public IActionResult GetCites()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var foundCity = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == id);

            if (foundCity == null)
            {
                return NotFound();
            }

            return Ok(foundCity);

        }

    }
}
