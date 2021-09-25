using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, factorial = 1, number;
            Console.Write("Unesite pozitivan ceo broj: ");
            //Unosi se pozitivan ceo broj
            number = int.Parse(Console.ReadLine());
            //Iteracija u zavisnosti od unetog broja i dobija se faktorijel
            for (i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            //Stampa
            Console.Write("Faktorijel broja " + number + " je: " + factorial);
        }
    }
}
