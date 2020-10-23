using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ukrain
{
    class Kiev
    {
        private string country_m_ukr;
        private string city_m_ukr;
        private int population_m_ukr;

        public Kiev()
        {
            country_m_ukr = "Ukraine";
            city_m_ukr = "Kiev";
            population_m_ukr = 4000000;
        }

        public void Kiev_showed()
        {
            Console.WriteLine($"Country {country_m_ukr} capital is {city_m_ukr}  population - {population_m_ukr}");
        }

        public int inhabited_Kiev()
        {
            Console.WriteLine($"population Kiev - {population_m_ukr}");
            return population_m_ukr;
        }
    }
}

