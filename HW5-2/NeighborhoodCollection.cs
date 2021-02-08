using System;
using System.Collections.Generic;
using System.Text;

namespace HW5_2
{
    class NeighborhoodCollection
    {
        public List<Neighborhood> Neighborhoods { set; get; }

        public NeighborhoodCollection()
        {
            List<Neighborhood> neighborhoods = new List<Neighborhood>();

            List<City> cities= new CityCollection().Cities;

            neighborhoods.Add(new Neighborhood("пл. Ленина", "1а", cities.Find(c => c.CityCode == 111)));
            neighborhoods.Add(new Neighborhood("б-р Штоккерау", "25", cities.Find(c => c.CityCode == 112)));
            neighborhoods.Add(new Neighborhood("Сиднейская", "110", cities.Find(c => c.CityCode == 111)));
            neighborhoods.Add(new Neighborhood("Мельбурнская", "01", cities.Find(c => c.CityCode == 311)));

            Neighborhoods = neighborhoods;

        }

    }
}
