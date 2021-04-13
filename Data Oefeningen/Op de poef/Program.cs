using System;

namespace Op_de_poef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ResultScreen(BarInput());
        }

        public static double BarInput()
        {
            double result = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Voer bedrag in:");
                //result = result + Convert.ToDouble(Console.ReadLine());
                result += Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"De poef staat op {result:C}.");
            }
            return result;
        }
        public static void ResultScreen(double result)
        {
            Console.WriteLine("\n*********************************\n");
            Console.WriteLine($"Het totaal van de poef is {result:C} en zal {Math.Ceiling(result/10)} weken duren om volledig afbetaald te worden.");
        }
    }
}
