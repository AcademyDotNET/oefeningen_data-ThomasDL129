using System;

namespace Geometric_Fun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Graden van de hoek: ");
            double rad = Math.PI * (Convert.ToDouble(Console.ReadLine()) / 180.0);
            Console.WriteLine($"Sinus: {Math.Sin(rad)}");
            Console.WriteLine($"Cosinus: {Math.Cos(rad)}");
            Console.WriteLine($"Tangens: {Math.Tan(rad)}");
        }
    }
}
