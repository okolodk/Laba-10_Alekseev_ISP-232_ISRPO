namespace Задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPrintable> printables = new List<IPrintable>
            {
                new Book(),
                new Magazine(),
                new Book(),
                new Magazine(),
            };

            foreach (var printable in printables)
            {
                printable.PrintInfo();
            }
        }
    }
}
