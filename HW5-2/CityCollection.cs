using System;
using System.Collections.Generic;
using System.Text;

namespace HW5_2
{
    class CityCollection
    {
        public List<City> Cities { set; get; }

        public CityCollection()
        {
            Cities = new List<City>();
            DistrictCollection districtCollection = new DistrictCollection();

            this.Cities.Add(new City(111, "Витебск", districtCollection.Districts.Find(d => d.DistrictCode == 11)));
            this.Cities.Add(new City(112, "Брест", districtCollection.Districts.Find(d => d.DistrictCode == 11)));
            this.Cities.Add(new City(311, "Сидней", districtCollection.Districts.Find(d => d.DistrictCode == 31)));
            this.Cities.Add(new City(411, "Мельбурн", districtCollection.Districts.Find(d => d.DistrictCode == 41)));


        }

    }
}
