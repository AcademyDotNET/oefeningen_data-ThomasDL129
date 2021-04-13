using System;

namespace Orakeltje_van_Delphi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random years = new Random();

            Console.WriteLine($"Je zal nog {years.Next(5, 126)} jaar leven.");
            
        }
    }
}
