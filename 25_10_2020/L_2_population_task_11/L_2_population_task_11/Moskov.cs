using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Russia
{
    class Moskov
    {
        private string country_m;
        private string city_m;
        private int population_m;

        public Moskov ()
        {
            country_m = "Russia";
            city_m = "Moskov";
            population_m = 14000000;
        }

        public void Moskow_showed()
        {
            Console.WriteLine($"Country {country_m} capital is {city_m}  population - {population_m}");
        }

        public int inhabited_Moskov()
        {
            Console.WriteLine( $"population Moskow - {population_m}");
            return population_m;
        }
    }
}
