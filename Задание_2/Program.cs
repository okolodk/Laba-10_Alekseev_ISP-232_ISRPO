namespace Задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> digits = new List<int>();
            for (int i = 0; i < 20; i ++)
            {
                digits.Add(i + 1);
            }
            List<int> evenDigits = digits.FindAll(c => c % 2 == 0);

            List<int> multipleThreeDigits = digits.FindAll(c => c % 3 == 0);

            Console.WriteLine("Чётные числа: " + string.Join(", ", evenDigits));
            Console.WriteLine();
            Console.WriteLine("Числа, кратные 3: " + string.Join(", ", multipleThreeDigits));
        }
    }
}
