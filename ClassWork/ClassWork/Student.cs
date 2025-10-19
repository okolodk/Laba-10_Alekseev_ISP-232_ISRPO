
namespace ClassWork
{
     class Student : Person
    {
        public string Univerdity {  get; set; }

        public override void SayHello()
        {
            base.SayHello();
            Console.WriteLine($"Привет! Я {Name}, Учусь в {Univerdity}.");

        }
    }
   
}
