using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Citiesinfo.API.Controllers.Api
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        // GET api/values
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(CityDS.Current.cities);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            return new JsonResult(CityDS.Current.cities.FirstOrDefault(c => c.id==id));
        }

        // POST api/values
        [HttpPost]
        public JsonResult Post([FromBody]Models.City city)
        {
            city.id = CityDS.Current.cities.Count + 1;
            CityDS.Current.cities.Add(city);
            return Get(city.id);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            CityDS.Current.cities.Remove(CityDS.Current.cities.FirstOrDefault(c => c.id == id));
        }
    }
}
