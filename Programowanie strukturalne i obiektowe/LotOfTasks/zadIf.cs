using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Instrukcja If:
1.Program sprawdzający czy podana liczba jest parzysta czy nieparzysta
2. Program sprawdzający czy podana liczba jest dodatnia, ujemna czy równa zero
3. Program sprawdzający czy podany rok jest rokiem przestępnym
4. Program wyświetlający odpowiedni komunikat w zależności od podanej oceny (np. "bardzo dobry" dla oceny 5, "dobry" dla oceny 4 itd.)
5.Program sprawdzający czy podane hasło jest poprawne (np. jeśli hasło jest "abc123", program powinien wyświetlić "hasło poprawne", jeśli jest inne, powinien wyświetlić "hasło niepoprawne").
6.Program sprawdzający czy podana data jest poprawna (np. sprawdzając, czy dzień jest z zakresu od 1 do 31, miesiąc od 1 do 12 itd.)
7.Program wyświetlający odpowiedni komunikat w zależności od podanej temperatury (np. "ciepło" dla temperatury powyżej 20 stopni Celsjusza, "chłodno" dla temperatury poniżej 10 stopni Celsjusza itd.)

*/

namespace LotOfTasks
{
    internal class zadIf
    {
        public void zadIf1()
        {
            Console.WriteLine("Podaj liczbe: ");
            string num1 = Console.ReadLine();
            int number = int.Parse(num1);

            if (number % 2 ==0)
            {
                Console.WriteLine("liczba: " + number + " jest parzysta");
            }
            else
                Console.WriteLine("liczba: " + number + " nie jest parzysta");
        }
        public void zadIf2()
        {
            Console.WriteLine("Podaj liczbe: ");
            string num1 = Console.ReadLine();
            int number = int.Parse(num1);

            if (number < 0)
                Console.WriteLine("podana liczba jest ujemna");
            else if (number == 0)
                Console.WriteLine("podana liczba jest równa zero");
            else
                Console.WriteLine("podana liczba jest dodatnia");
        }
        public void zadIf3()
        {
            Console.WriteLine("Podaj rok: ");
            string num1 = Console.ReadLine();
            int year = int.Parse(num1);

            if (year % 4 == 0)
            {
                Console.WriteLine("rok: " + year + " jest rokiem przestępnym");
            }
            else
                Console.WriteLine("rok: " + year + " nie jest rokiem przestępnym");
        }
        public void zadIf4()
        {
            Console.WriteLine("Podaj ocenę od 1-6: ");
            string num1 = Console.ReadLine();
            int mark = int.Parse(num1);

            if (mark == 6)
            {
                Console.WriteLine(" wzorowa");
            }
            if (mark == 5)
            {
                Console.WriteLine(" bardzo dobra");
            }
            if (mark == 4)
            {
                Console.WriteLine(" dobra");
            }
            if (mark == 3)
            {
                Console.WriteLine(" dostateczna");
            }
            if (mark == 2)
            {
                Console.WriteLine(" dopuszcająca");
            }
            if (mark == 1)
            {
                Console.WriteLine(" niedostateczna");
            }
            if (mark > 6)
            {
                Console.WriteLine(" z poza przedziału");
            }
            else if (mark < 1)
            {
                Console.WriteLine(" z poza przedziału");
            }
        }
        public void zadIf5()
        {
            Console.WriteLine("Podaj hasło: ");
            string password = Console.ReadLine();
          

            if(password == "abc123")
            {
                Console.Write(" Podane hasło jest prewidłowe");
            }
            else 
            {
                Console.Write(" Podane hasło nie jest prawidłowe");
            }
        }
        public void zadIf6()
        {
            Console.WriteLine("Podaj dzień miesiąca: ");
            string day1 = Console.ReadLine();
            int day = int.Parse(day1);

            if (day < 32)
            {
                Console.WriteLine("Podaj miesiąc roku: ");
                string month1 = Console.ReadLine();
                int month = int.Parse(month1);
                if(month <= 12)
                {
                    Console.WriteLine("Podałeś: " + day +","+month);
                }
                else
                {
                    Console.WriteLine("error - I CAN'T OPEN THE EA APP\r\nSearch for ErrorReporter" +
                   ".exe in Windows Explorer.\r\nClick the Start or Windows button and use the search bar.\r\nIf " +
                   "the search doesn’t work, try going to C:\\Program Files\\Electronic " +
                   "Arts\\EA Desktop\\EA Desktop\\ in Windows Explorer.\r\nClick the Start " +
                   "or Windows button and click My Computer.\r\nDouble-click your C: drive, followed by Program Files," +
                   " then the EA app (twice).\r\nDouble-click ErrorReporter.exe to run the EA Error Reporter." +
                   "\r\nChoose the Type of problem you’re having.\r\nTell us about the issue you’re having in" +
                   " the Description of problem box.\r\nIf you’re running the Error Reporter as part of your EA Help case, include your Case Number in the Support Ticket Number (Optional) box.\r\nYou " +
                   "can find your Case Number in your cases on EA Help or inside any support emails we sent you about this issue." +
                   "\r\nCheck the box next to Share diagnostic information when a " +
                   "report is submitted.\r\nClick Submit report and wait" +
                   " for it to complete.\r\nWrite down your Report ID for safekeeping.");
                }
            }
            else
            {
                Console.WriteLine("error - I CAN'T OPEN THE EA APP\r\nSearch for ErrorReporter" +
                    ".exe in Windows Explorer.\r\nClick the Start or Windows button and use the search bar.\r\nIf " +
                    "the search doesn’t work, try going to C:\\Program Files\\Electronic " +
                    "Arts\\EA Desktop\\EA Desktop\\ in Windows Explorer.\r\nClick the Start " +
                    "or Windows button and click My Computer.\r\nDouble-click your C: drive, followed by Program Files," +
                    " then the EA app (twice).\r\nDouble-click ErrorReporter.exe to run the EA Error Reporter." +
                    "\r\nChoose the Type of problem you’re having.\r\nTell us about the issue you’re having in" +
                    " the Description of problem box.\r\nIf you’re running the Error Reporter as part of your EA Help case, include your Case Number in the Support Ticket Number (Optional) box.\r\nYou " +
                    "can find your Case Number in your cases on EA Help or inside any support emails we sent you about this issue." +
                    "\r\nCheck the box next to Share diagnostic information when a " +
                    "report is submitted.\r\nClick Submit report and wait" +
                    " for it to complete.\r\nWrite down your Report ID for safekeeping.");
            }
            
        }
        public void zadIf7()
        {
            Console.WriteLine("Podaj temperature: ");
            string temp = Console.ReadLine();
            int temperatura = int.Parse(temp);

            if (temperatura >= 10 )
                Console.WriteLine(temperatura + " - ciepło");
            if (temperatura >= 0 && temperatura < 10)
                Console.WriteLine(temperatura + " - chłodno");
            if (temperatura < 0 && temperatura > -10)
                Console.WriteLine( temperatura + " - zimno");
            if(temperatura < -10)
                Console.WriteLine( temperatura + " - bardzo zimno");

        }



    }
}
