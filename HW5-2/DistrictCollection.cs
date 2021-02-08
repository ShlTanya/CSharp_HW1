using System;
using System.Collections.Generic;
using System.Text;

namespace HW5_2
{
    class DistrictCollection
    {
        public List<District> Districts { set; get; }

        public DistrictCollection()
        {
            Districts = new List<District>();
            CountryCollection countryCollection = new CountryCollection();
            this.Districts.Add(new District(11, "Витебская обл.", countryCollection.Countries.Find(c => c.CountryCode == 1)));
            this.Districts.Add(new District(22, "Брестская обл.", countryCollection.Countries.Find(c => c.CountryCode == 2)));
            this.Districts.Add(new District(31, "Новый Южный Уэльс", countryCollection.Countries.Find(c => c.CountryCode == 3)));
            this.Districts.Add(new District(41, "Виктория", countryCollection.Countries.Find(c => c.CountryCode == 4)));
        }

    }
}
