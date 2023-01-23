using System;

namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WriteLine przechodzi do nowej lini
            Console.WriteLine("Hello World!");
            Console.Write("Hello World!");

            int number = 57;

            Console.Write("Wartość zmiennej to: ");
            Console.WriteLine(number);

            Console.WriteLine("Wartość zmiennej to: " + number);
            //to jest to samo, w innym zapisie
            Console.WriteLine($"Wartość zmiennej to {number}");

            Console.WriteLine($"Wartość zmiennej to {number}");

            //Console.WriteLine($"Wartość zmiennej to {number} km\h");
            Console.WriteLine(@$"Wartość zmiennej to {number}km\h");
            //@ informuje kompilator zeby traktował"\" jako zwykle znaki

            // operatory porownania: >,<,<=,>=,==,!=

        }
    }
}
