namespace ClassWork.async
{
    internal class Program
    {
        static async Task Main()
        {
            Console.WriteLine("1. Включили чайник... ");
            Task boilTask = BoilWaterAsync();
            Task sliceTask = SliceLemonAsync();
            await Task.WhenAll(boilTask, sliceTask);
            Console.WriteLine("3. Завариваем чай ");
        }
        static async Task BoilWaterAsync()
        {
            Console.WriteLine("2. Кипятим воду (ждём 3 секунды)...");
            await Task.Delay(3000);
            Console.WriteLine("...вода закипела");
        }
        static async Task SliceLemonAsync()
        {
            Console.WriteLine("3. Режм лимон (ждём 2 секунды)...");
            await Task.Delay(2000);
            Console.WriteLine("...лимон порезан");
        }

    }
}
