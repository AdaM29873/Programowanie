using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Trudniejsze zadania:
1.Program implementujący algorytm szyfrowania Cezara (proste szyfrowanie, w którym każdy znak w tekście jest zastępowany innym znakiem, przesuniętym o stałą liczbę pozycji w alfabecie).
2.Program obliczający największy wspólny dzielnik (NWD) dwóch liczb
3. Program obliczający najmniejszą wspólną wielokrotność (NWW) dwóch liczb.
4. Program wyciągający informacje z numeru PESEL
5. Napisz program, który pobiera od użytkownika ciąg znaków i wyświetla liczbę samogłosek i spółgłosek w tym ciągu.
Dla zaawansowanych:
1. Program implementujący algorytm generowania liczb pseudolosowych (np.algorytm Mersenne Twister).
2.Algorytm szyfrowania AtBash Cipher - algorytm szyfrujący, w którym każda litera jest zamieniana na literę z przeciwnej strony alfabetu (np. A na Z, B na Y itd.)
3.Algorytm szyfrowania Morse'a - algorytm szyfrujący, w którym każda litera w tekście jest zamieniana na ciąg znaków "+" i "-", zgodny z kodem Morse'a.
4. Napisz program, który pobiera od użytkownika dwie macierze kwadratowe o takim samym rozmiarze i wyświetla ich iloczyn.
5. Program który na wejściu przyjmie równanie a na wyjściu da równanie w odwrotnej notacji polskiej ONP. Np. na wejściu 2+3*4 na wyjścu da 234*+
6. Program, który na wejściu przyjmie rówanie w ONP a na wyjściu wyświetli wynik rówania.
7. Napisz grę kółko i krzyżyk.*/
namespace LotOfTasks
{
    internal class Hard
    {
        public void zadHard1()
        {

        }
        public void zadHard2()
        {
            Console.WriteLine("Podaj liczbe: ");
            string num1 = Console.ReadLine();
            int number = int.Parse(num1);

            Console.WriteLine("Podaj drugą liczbe: ");
            string num2 = Console.ReadLine();
            int number2 = int.Parse(num2);

            int nwd;
            int minus;
            Console.WriteLine();
            if (number > number2)
            {
                minus = number - number2;
                do
                {
                    nwd = number - minus;
                } while (number2 > number);
                Console.WriteLine(nwd + " to najwiekszy wspolny dzielnik");
                return;
            }
            if (number2 > number)
            {
                minus = number2 - number;

                do
                {
                    nwd =number2 - minus;
                }while (number2 < number);
                Console.WriteLine(nwd + " to najwiekszy wspolny dzielnik");
                return;
            }
            else
            {
                nwd = number;
                Console.WriteLine(number + " to najwiekszy wspolny dzielnik");
                return;
            }

        }    
    
       
        public void zadHard3()
        {

        }
        public void zadHard4()
        {

        }


    }
}
