using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Pętla for:
1.Program wyświetlający na ekranie kolejne liczby naturalne od 1 do 10
2.Program obliczający sumę liczb od 1 do 100
3. Program wyświetlający na ekranie kwadraty liczb od 1 do 10 (np. 1, 4, 9, 16 itd.)
4.Program wyświetlający na ekranie silnie z liczb od 1 do 10 (np. 1!, 2!, 3!, 4! itd.)
5.Program wyświetlający na ekranie tabliczkę mnożenia od 1 do 9 (np. 1x1=1, 1x2=2, 1x3=3 itd.).
6.Program wyświetlający na ekranie wszystkie liczby podzielne przez 3 z zakresu od 1 do 100
7.Program obliczający sumę kwadratów liczb od 1 do 10
8. Program wyświetlający na ekranie ciąg Fibonacciego do 20 elementu (ciąg Fibonacciego to ciąg gdzie każdy element jest sumą dwóch poprzednich, np. 0, 1, 1, 2, 3, 5, 8, 13 itd.)
9.Program wyświetlający na ekranie kolejne potęgi 2 od 2^0 do 2^10 (np. 2^0, 2^1, 2^2 itd.)
10.Program wyświetlający na ekranie kolejne elementy ciągu a_n = a_{n-1} +a_{ n - 2}, gdzie a_0 = 1, a_1 = 1(ciąg ten zaczyna się od 1, 1, 2, 3, 5, 8, 13 itd.).

*/
namespace LotOfTasks
{
    internal class PetlaFor
    {
        public void petlaF1()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.Write(i+",");   
            }
        }
        public void petlaF2()
        {
            int suma = 0;
            for(int i =0; i <= 100; i++)
            {
                suma +=i;
            }
            Console.WriteLine(suma);
        }
        public void petlaF3()
        {
            int suma;
            for(int i=0;i<=20;i++)
            {
                suma = i * i;
                Console.Write(suma+",");
            }
        }
        public void petlaF4()
        {
            int result;
            int n2;
            for (int i = 0; i < 10; i++)
            {
                n2 = i + 1;
                result = i * n2;
                Console.WriteLine(i + "*" + n2 + "=" + result);

            }
            Console.WriteLine("silnia");
            int result2 = 1;
            for (int i = 1; i <= 10; i++)
            {
                result2 *= i;

                Console.Write(" * " + i + " = " + result2);
            }
           
        }
        public void petlaF5()
        {
            int main1 = 1;
            int result = 1;
            for (int i = 0; main1 <= 10; i++)
            {
                result = main1 * i;
                Console.WriteLine(main1 + "*" + i + "=" + result);
                if (i == 10)
                {
                    Console.WriteLine();
                    main1++;
                    i = 0;
                }
            }
        }
        public void petlaF6()
        {
            for(int i = 1; i <= 100; i++)
            {
                if(i%3==0)
                {
                    Console.Write(i+",");
                }
            }
        }
        public void petlaF7()
        {
            int suma = 0;
            for(int i=1; i<11;i++)
            {
                suma = suma + (i * i);
            }
            Console.WriteLine(suma);
        }
        public void petlaF8()
        {
            int a = 0, b = 1;

            for (int i = 0; i < 21; i++)
            {
                Console.Write( b+",");
                b += a; 
                a = b - a; 
            }
        }
        public void petlaF9()
        {
            Console.WriteLine("Drogi Użytkowniku, wkradł się lekki błąd, trwają prace techniczne ");
            int suma = 2;
            Console.WriteLine("potęgi od 2 do 10 liczby 2 ");
            for(int i=3;i<11;i++)
            {
                for (int b=2; b < i; b++) 
                {
                    suma *= 2;
                    Console.WriteLine("2^"+b+"="+suma);
                }
            }
        }
    }
}
