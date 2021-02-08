using System;
using System.Collections.Generic;
using System.Text;

namespace HW5_2
{
    class Country
    {
        public int CountryCode { set; get; }
        public string CountryName { set; get; }

        public Country(int countryCode, string countryName)
        {
            this.CountryCode = countryCode;
            this.CountryName = countryName;
        }


        /*      public Country( int countryCode, string countryName,
                              int districtCode, string distrcitName,
                              int cityCode, string cityName,
                              string streetName, string houseNumber)
              {
                  this.CountryCode = countryCode;
                  this.CountryName = countryName;
                  this.District = new District(districtCode, distrcitName, new City(cityCode, cityName, new Neighborhood(streetName, houseNumber)));

              }*/
    }
}
