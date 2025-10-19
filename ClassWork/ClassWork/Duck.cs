namespace ClassWork
{
    public class Duck : IFlier,ISwimmer
    {
        public void Fly() => Console.WriteLine("Утка летит");
        public void Swim() => Console.WriteLine("Утка плывёт");
    }
}
