using System;

namespace Data_Oefeningen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1ste kommagetal");
            double getal1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2de kommagetal");
            double getal2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("3de kommagetal");
            double getal3 = Convert.ToDouble(Console.ReadLine());

            double result = (getal1 + getal2 + getal3) / 3;
            Console.WriteLine($"Gemiddelde: {result}");
        }
    }
}
