namespace ClassWork
{
    internal class Person
    {
        public string Name { get; set; }
        public virtual void SayHello()
        {
            Console.WriteLine($"Привет,мен зовут{Name}");
        }
    }
}
