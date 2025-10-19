using System.Globalization;
using System.Linq;
namespace ClassWork.Corytin.LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int> { 5, 2, 9, 4, 7, 3, 8, 23, 45, 12, 34, 13, 98, 67, 56, 99 };
            List<int> evenNumber = new List<int>();
            foreach (var num in number)
            {
                if (num % 2 == 0)
                    evenNumber.Add(num);
            }
            List<int> multiplied = new List<int>();
            foreach (var num in evenNumber)
            {
                multiplied.Add(num * 10);
            }
            multiplied.Sort((a,b) => b.CompareTo(a));
            Console.WriteLine("рузкльтат (без LINQ):");
            foreach(var num in multiplied)
            {
                Console.WriteLine(num);
            }
            var result = number
                .Where(n => n % 2 == 0)
                .Select(n => n * 10)
                .OrderByDescending(n => n);
            Console.WriteLine("Результат (с LINQ):");
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }

            List<string> names = new List<string> { "Анна", "Иван", "Мария", "Пёрт" };

            List<string> longNames = new List<string>();
            foreach (var name in names)
            {
                if (name.Length > 4 )
                    longNames.Add(name);

            }
            foreach(var name in longNames)
            {
                Console.WriteLine(name);
            }
            var lingNames = names.Where(name => name.Length > 4);
            foreach( var name in lingNames)
            {
                Console.WriteLine(name);
            }
            List<int> nums = new List<int> { 10, 5, 20, 5 };
            int min = nums[0];
            foreach(var num in nums)
            {
                if (num < min)
                    min = num;
            }
            Console.WriteLine($"\nМинимальное число(без LINQ) : {min} ");

            int linqMin = nums.Min();
            Console.WriteLine($"Минимальное число (с LINQ): {linqMin}");

            List<int> numbers = new List<int> { 1,2,3,4, };
            List<int> squares = new List<int>();
            foreach(var num in numbers)
            {
                squares.Add(num * num);
            }
            Console.WriteLine("\nКвадраты чисел(без LINQ):");
            Console.WriteLine(string.Join(",",squares));

            var linqSquares = numbers.Select(n => n * n);
            Console.WriteLine("Квадраты чисел (с LINQ):");
            Console.WriteLine(string.Join(",",linqSquares));
        }

    }
}

