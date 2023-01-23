using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstObjectConsoleApp
{
    internal class Person
    {
        private string name;
        private string surname;
        private int age;

        public Person()
        {
            name = "Jan";
            surname = "Nieznany";
            age = 21;

        }
        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Informacja o osobie: ");
            Console.WriteLine($"imie: {name}");
            Console.WriteLine($"nazwisko: {surname}");
            Console.WriteLine($"wiek{age}");


        }
    }


}
