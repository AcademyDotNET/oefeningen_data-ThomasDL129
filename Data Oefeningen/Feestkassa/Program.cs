using System;

namespace Feestkassa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Frietjes?");
            int fries = 20* Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tussenprijs = {fries:C}");

            Console.WriteLine("Koningenhapjes?");
            int hapjes = 10* Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tussenprijs = {fries:C} + {hapjes:C}");

            Console.WriteLine("Ijsjes?");
            int icecream = 3* Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tussenprijs = {fries:C} + {hapjes:C} + {icecream:C}");

            Console.WriteLine("Dranken?");
            int drinks = 2* Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tussenprijs = {fries:C} + {hapjes:C} + {icecream:C} + {drinks:C}");

            Console.WriteLine($"\nHet totaal te betalen bedrag is {fries + hapjes + icecream + drinks:C}.");
        }
    }
}
