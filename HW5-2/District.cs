using System;
using System.Collections.Generic;
using System.Text;

namespace HW5_2
{
    class District
    {
        public int DistrictCode { set; get; }
        public string DistrictName { set; get; }
        public Country Country { set; get; }
        public District (int districtCode, string districtName, Country country)
        {
            this.DistrictCode = districtCode;
            this.DistrictName = districtName;
            this.Country = country;
        }
    }
}
