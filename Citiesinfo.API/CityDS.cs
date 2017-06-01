using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Citiesinfo.API
{
    public class CityDS
    {
        public List<Models.City> cities { get; set; }
        public static CityDS Current { get; } = new CityDS();
        public CityDS()
        {
            cities = new List<Models.City>()
            {
                new Models.City()
                {
                    id=1,
                    name ="Dublin",
                    description ="Dublin the city"
                },
                new Models.City(){
                    id =2,
                    name ="Cork",
                    description ="Avnet Headoffice"
                },
                new Models.City(){
                    id =3,
                    name ="Limerick",
                    description ="Middle of nowhere"
                }

            };
        }
    }
}
