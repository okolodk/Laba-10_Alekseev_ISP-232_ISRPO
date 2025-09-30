﻿namespace Задание_5
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Ждём данные... Осталось 2 секунды.");

            int result = await GetDataAsync();

            Console.WriteLine("Данные получены!");
            Console.WriteLine($"Результат: {result}");
        }
        static async Task<int> GetDataAsync()
        {
            await Task.Delay(2000);
            return 0;
        }
    }
}
