namespace ClassWork
{
    internal interface INamed
    {
        string Name { get; set; }       
    }
    public class Book : INamed
    {
        public string Name { get; set; }
    }
}
