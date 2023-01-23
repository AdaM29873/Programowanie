using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Pętla do -while:
1.Program pytający użytkownika o hasło i wyświetlający komunikat "hasło poprawne" lub "hasło niepoprawne" dopóki użytkownik nie poda poprawnego hasła (np. "abc123").
2.Program wyświetlający na ekranie kwadraty liczb od 1 do 10 (np. 1, 4, 9, 16 itd.) dopóki suma tych kwadratów nie przekroczy 1000.
*/
namespace LotOfTasks
{
    internal class PetlaDoWhile
    {
        public void petlaDW1()
        {
            string pass;
            do
            {
                Console.WriteLine("Podaj hasło: ");
                string password = Console.ReadLine();
                if (password == "abc123")
                    Console.WriteLine("hasło poprawne");
                else
                    Console.WriteLine("hasło niepoprawne");
                pass = password;
            } while (pass != "abc123");
        }
        public void petlaDW2()
        {
            double number=1;
            double sum=0;
            do
            {
                Console.WriteLine(sum = Math.Pow(number, 2));
                number++;
            } while (sum < 1000);
            Console.WriteLine(sum);
        }
    }
}
