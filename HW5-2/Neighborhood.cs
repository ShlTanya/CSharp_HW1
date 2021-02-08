using System;
using System.Collections.Generic;
using System.Text;

namespace HW5_2
{
    class Neighborhood
    {
        public string StreetName { set; get; }
        public string HouseNumber { set; get; }
        public City City { set; get; }

        public Neighborhood(string streetName, string houseNumber, City city)
        { 
            this.StreetName = streetName;
            this.HouseNumber = houseNumber;
            this.City = city;
        }

    }
}
