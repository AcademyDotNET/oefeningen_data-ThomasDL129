using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lengte: ");
            double lengte = Convert.ToDouble(Console.ReadLine());
            Console.Write("Gewicht: ");
            double gewicht = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"BMI: {Math.Round(gewicht/Math.Pow(lengte, 2), 2, MidpointRounding.AwayFromZero)}");
        }
    }
}
