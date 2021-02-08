using System;
using System.Collections.Generic;
using System.Text;

namespace HW5_2
{
    class City
    {
        public int CityCode { set; get; }
        public string CityName { set; get; }
        public District District { set; get; }

        public City (int cityCode, string cityName, District district)
        {            
            this.CityCode = cityCode;
            this.CityName = cityName;
            this.District = district;
        }
    }
}
