namespace Задани_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new
            {
                Name = "Григорий",
                Age = 19,
                Group = "ISP-232"
            };
            Console.WriteLine($"Имя: {student.Name}");
            Console.WriteLine($"Возраст: {student.Age}");
            Console.WriteLine($"Группа: {student.Group}");
            Console.WriteLine();

            var students = new[]
{
                new { Name = "A", Age = 1, Group = "ISP-231" },
                new { Name = "B", Age = 2, Group = "ISP-232" },
                new { Name = "C", Age = 3, Group = "ISP-233" },
                new { Name = "D", Age = 4, Group = "ISP-234" },
                new { Name = "E", Age = 5, Group = "ISP-235" },
            };
            foreach (var s in students)
            {
                Console.WriteLine($"| {s.Name} | {s.Age} | {s.Group} |");
            }
        }
    }
}
