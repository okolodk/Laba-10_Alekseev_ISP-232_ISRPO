using System.Collections.Generic;

namespace Задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities = new List<string> { "Москва", "Санкт-Петербург", "Новосибирск", "Екатеринбург", "Казань", "Киров", "Челябинск", "Самара", "Омск", "Ростов-на-Дону" };

            var startsWithK = cities.Where(city => city.StartsWith("К"));
            Console.WriteLine("Города на 'К': " + string.Join(", ", startsWithK));

            var sortCitiesLength = cities.OrderBy(city => city.Length);
            Console.WriteLine("sort Length: " + string.Join(", ", sortCitiesLength));

            var citiesMoreLength = cities.Where(city => city.Length > 6);
            Console.WriteLine("more 6: " + string.Join(", ", citiesMoreLength));
        }
    }
}
