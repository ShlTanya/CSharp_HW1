using System;
using System.Collections.Generic;
using System.Text;

namespace HW5_2
{
    class CountryCollection
    {
        public List<Country> Countries { set; get; }

        public  CountryCollection()
        {
            Countries = new List<Country>();
            Countries.Add(new Country(1, "Беларусь"));
            Countries.Add(new Country(2, "Австралия"));
            Countries.Add(new Country(3, "Китай"));
            Countries.Add(new Country(4, "Россия"));
        }

    }
}
