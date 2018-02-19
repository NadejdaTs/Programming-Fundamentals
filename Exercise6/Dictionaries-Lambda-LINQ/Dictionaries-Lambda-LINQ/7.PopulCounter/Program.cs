using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.PopulCounter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var countryDictionary = new SortedDictionary<string, long>();
            var cityDictionary = new Dictionary<string, long>();

            while (true)
            {
                var rawData = Console.ReadLine()
                .Split('|')
                .ToList();

                if (rawData[0] == "report") break;
                var text = rawData;
                var city = rawData[0];
                var country = rawData[1];
                var populationCount = long.Parse(rawData[2]);

                if (!countryDictionary.ContainsKey(country))
                {
                    countryDictionary[country] = 0;
                }
                countryDictionary[country] += populationCount;

                if (!cityDictionary.ContainsKey(city))
                {
                    cityDictionary[city] = 0;
                }
                cityDictionary[city] += populationCount;
            }
            foreach (var country in countryDictionary.OrderByDescending(x => x.Value))
            {
                //Bulgaria (total population: 1000000) c.Value.OrderByDescending(x => x.Value)
                Console.WriteLine($"{country.Key} (total population: {country.Value})");
                    
            }
            foreach (var city in cityDictionary.OrderByDescending(x => x.Value))
            {
                //=>Sofia: 1000000
                Console.WriteLine($"=>{city.Key}: {city.Value}");
            }
        }
    }
}
