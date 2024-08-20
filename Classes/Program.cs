namespace Classes
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Car ferarri = new Car();
            Console.WriteLine(ferarri.Make = "Ferrari");
            Console.WriteLine(ferarri.Model = "488 GTB Base");
            Console.WriteLine(ferarri.Year = "2018");
            
            
        }
    }
}
