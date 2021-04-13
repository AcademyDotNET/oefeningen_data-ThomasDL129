using System;

namespace Random_Invoer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Supercomputer oefening meet random invoer

            double getal1 = Randomizer();
            double getal2 = Randomizer();
            double getal3 = Randomizer();
            Console.WriteLine($"1ste kommagetal: {getal1}");
            Console.WriteLine($"2de kommagetal: {getal2}");
            Console.WriteLine($"3de kommagetal: {getal3}");

            double result = (getal1 + getal2 + getal3) / 3;
            Console.WriteLine($"Gemiddelde: {Math.Round(result, 2, MidpointRounding.AwayFromZero)}");
        }

        public static double Randomizer()
        {
            Random myRando = new Random();
            double getal = myRando.Next(0, 1000) + Math.Round(myRando.NextDouble(), 2, MidpointRounding.AwayFromZero);
            return getal;
        }
    }
}
