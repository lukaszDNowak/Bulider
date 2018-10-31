using System;

namespace Bulider
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wytwórnia Toyoty");
            Director director = new Director(new Avensis());
            director.Construct();
            Console.WriteLine(director.GetBuildedParts());
            director = new Director(new Corolla());
            director.Construct();
            Console.WriteLine(director.GetBuildedParts());
            //wynik
            //Wytwórnia Toyoty
            //Podwozie Avensis Silnik Avensis Nadwozie Avensis
            //Podwozie Corolla Silnik Corolla Nadwozie Corolla
            Console.Read();
            Console.ReadKey();
        }
    }

    internal class Avensis : IBulider
    {
        public string BuildBody() =>  "Podwozie Avensis";
        public string BuildChassis() => "Silnik Avensis";
        public string BuildEngine() => "Nadwozie Avensis";
    }

    internal class Corolla : IBulider
    {
        public string BuildBody() => "Podwozie Corolla";
        public string BuildChassis() => "Silnik Corolla";
        public string BuildEngine() => "Nadwozie Corolla";
    }

    public interface IBulider
    {
        string BuildChassis();
        string BuildEngine();
        string BuildBody();
    }
    public class Director 
    {
      private IBulider bulider;
        public Director(IBulider _bulider) => bulider = _bulider;
        internal void Construct()
        {
            bulider.BuildBody();
            bulider.BuildChassis();
            bulider.BuildEngine();
        }
        internal string GetBuildedParts() => (bulider.BuildBody() + " " + bulider.BuildChassis() + " " + bulider.BuildEngine()).ToString();
    }
}
