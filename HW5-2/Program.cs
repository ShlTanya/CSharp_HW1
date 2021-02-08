using System;
using System.Linq;
using System.Collections.Generic;

namespace HW5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Country> cc= new CountryCollection().Countries;
            List<District> dc = new DistrictCollection().Districts;
            List<City> ctc = new CityCollection().Cities;
            List<Neighborhood> nbc = new NeighborhoodCollection().Neighborhoods;

            var results = from country in cc
                          join d in dc on country.CountryCode equals d.Country.CountryCode
                          join ct in ctc on d.DistrictCode equals ct.District.DistrictCode 
                          join nb in nbc on ct.CityCode equals nb.City.CityCode
                          select new { nb.StreetName };

            foreach (var result in results)
            {
                 Console.WriteLine($"street: {result.StreetName}");
            }
            Console.ReadKey();

        }
    }
}
