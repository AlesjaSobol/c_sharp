using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Belarus
{
    class Minsk
    {
        private string country_m;
        private string city_m;
        private int population_m;

        public Minsk()
        {
            country_m = "Belorusia";
            city_m = "Minsk";
            population_m = 20000000;
        }

        public void Minsk_showed()
        {
            Console.WriteLine($"Country {country_m} capital is {city_m}  population - {population_m}");
        }

        public int inhabited_Minsk()
        {
            Console.WriteLine($"population Minsk - {population_m}");
            return population_m;
        }
    }
}

