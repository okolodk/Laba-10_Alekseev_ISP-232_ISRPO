using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    internal interface IPrintable
    {
        void PrintInfo();
    }
    public class Book : IPrintable
    {
        private static Random random = new Random();

        public void PrintInfo()
        {
            Console.WriteLine($"Книге: {random.Next(1, 100)} лет.");
        }
    }

    public class Magazine : IPrintable
    {
        private static Random random = new Random();

        public void PrintInfo()
        {
            Console.WriteLine($"Журналу: {random.Next(1, 20)} лет.");
        }
    }
}
