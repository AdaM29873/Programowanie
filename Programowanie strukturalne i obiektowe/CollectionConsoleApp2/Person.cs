using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsoleApp2
{
    internal class Person
    {
        public string name;
        public string surname;
        public int age;
        public int height;

        public  Person(string name, string surname, int age , int height)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.height = height;

        }
    
        public void info()
        {
            Console.WriteLine("imie: " + name);
            Console.WriteLine("nazwisko: " + surname);
            Console.WriteLine("wiek: " + age);
            Console.WriteLine(height + "cm");
        }
    }
}
