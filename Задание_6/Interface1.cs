using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Задание_6
{
    internal interface IPerson
    {
        public string name { get; set; }
        public void GetDescription();
    }
    class Student : IPerson
    {
        public string name { get; set; }
        public int age { get; set; }

        public void GetDescription()
        {
            Console.WriteLine($"Студент: {name}. Возраст студента: {age}.");
        }
    }
    class Teacher : IPerson
    {
        public string name { get; set; }
        public string department {  get; set; }
        public void GetDescription()
        {
            Console.WriteLine($"Преподаватель: {name}. C кафедры: {department}.");
        }
    }

}
