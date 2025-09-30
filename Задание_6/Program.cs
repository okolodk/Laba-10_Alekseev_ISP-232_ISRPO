namespace Задание_6
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Загрузка данных..");
            var students = await LoadStudentsAsync();

            var teachers = new List<Teacher>
            {
                new Teacher{name = "AAA", department = "A1"},
                new Teacher{name = "BBB", department = "B1"},
                new Teacher{name = "CCC", department = "C1"},
                new Teacher{name = "CCC", department = "D1"},


            };

            List<IPerson> peopls = new List<IPerson>();
            peopls.AddRange(students);
            peopls.AddRange(teachers);

            var studentsAgeMore = students.Where(c => c.age > 20).ToList();
            Console.WriteLine("Студенты старше 20 лет:");
            foreach (var student in studentsAgeMore)
            {
                student.GetDescription();
            }
            Console.WriteLine();

            string department = "A1";
            var teacherOfDepartment = teachers
                .Where(c => c.department.Equals(department, StringComparison.OrdinalIgnoreCase)).ToList();


            Console.WriteLine($"Преподаватели кафедры '{department}':");
            foreach (var teacher in teacherOfDepartment)
            {
                teacher.GetDescription();
            }

            Console.WriteLine("Сортировка по имени:");
            
            var sortNamePeopls = peopls.OrderBy(c => c.name).ToList();
            foreach (var people in sortNamePeopls)
            {
                people.GetDescription();
            }

        }

        static async Task<List<Student>> LoadStudentsAsync()
        {
            Console.WriteLine("Загрузка данных студентов...");
            await Task.Delay(5000);

            return new List<Student>
            {
                new Student { name = "A", age = 10 },
                new Student { name = "B", age = 19 },
                new Student { name = "C", age = 20 },
                new Student { name = "D", age = 21 },
            };
        }
    }
}
