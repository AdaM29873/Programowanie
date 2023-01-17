using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Pętle:
1.Program sprawdzający czy podana liczba jest liczbą pierwszą (czyli taką, która dzieli się tylko przez 1 i przez siebie samą)
2.Program sprawdzający czy podany ciąg znaków jest palindromem (czyli takim, który czytany od tyłu jest taki sam, jak czytany od przodu, np. "kajak")
3.Program sprawdzający czy podane dwa słowa są anagramami (czyli takimi, które zawierają te same litery, ale w innym układzie, np. "klasa" i "salka")
4.Program sprawdzający czy podana liczba jest liczbą doskonałą (czyli taką, której suma dzielników (z wyłączeniem samej siebie) jest równa danej liczbie, np. 6 jest liczbą doskonałą, ponieważ 1 + 2 + 3 = 6).

*/
namespace LotOfTasks
{
    internal class Petle
    {
        public void Petle1()
        {
            Console.WriteLine("Podaj liczbe: ");
            string num1 = Console.ReadLine();
            int number = int.Parse(num1);
            
            int i = 1;
            bool check;

            while(i < number)
            {
                if(number%i == 0)
                {
                    check = false;
                    i++;
                    break;
                }
                else
                {
                    check = true;
                    i++;
                }

            }

            if (check = true)
            {
                Console.WriteLine("Podałes liczbe pierwsza");
            }
            else
            {
                Console.WriteLine("liczba nie jest liczba pierwsza");
            }

        }
        public void Petle2()
        {
            Console.WriteLine("Podaj wyraz: ");
            string wyraz = Console.ReadLine();

           string wyrazWspak = "";
            for (int i = wyraz.Length - 1; i >= 0; i--)
                wyrazWspak = wyrazWspak + wyraz[i];

            Console.WriteLine("Podales: " + wyraz);
            Console.WriteLine("Wyraz wspak: " + wyrazWspak);

            if (wyraz == wyrazWspak)
            {
                Console.WriteLine("To jest palindrom\n");
            }
            else
                Console.WriteLine("To nie jest palindrom\n");
        }
    }
}
