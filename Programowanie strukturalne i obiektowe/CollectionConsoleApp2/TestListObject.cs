using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CollectionConsoleApp2
{
    internal class TestListObject
    {
        public void Test()
        {
            List<Person> listOfPeople = new List<Person>();
            Person person = new Person("Jan", "Kowalski", 40,200);
            listOfPeople.Add(person);
            listOfPeople.Add(new Person("Adam", "Nieznany", 20,180));

            Console.WriteLine("lista wszystkich osób: " );
            foreach(Person p in listOfPeople)
            {
                p.info();
            }

            List<Person> listOfPeoplePegi18;

            listOfPeoplePegi18 = listOfPeople.Where(x=> x.age >=18 ).ToList();
            Console.WriteLine();
            Console.WriteLine("lista osób pełnoletnich");
            foreach(Person p in listOfPeoplePegi18)
            {
                p.info();

            }
            Console.WriteLine();

            //List<Person> sortedListByAge = listOfPeople.OrderBy(x => x.age).ToList();
            List<Person> sortedListByAgeAndHeight = listOfPeople.OrderByDescending(x => x.age)
                .ThenBy(x => x.height)
                //.OrderBy(x => x.height)
                .ToList();
            Console.WriteLine("Lista osób posortowana według wieku malejąco i wzrostu");
            foreach (Person p in sortedListByAgeAndHeight)
            {
                p.info();
            }
            Console.WriteLine();

            List<Person> sortedListByName = listOfPeople.OrderBy(x => x.name).ToList();
            Console.WriteLine("Lista osób posortowana według imienia");
            foreach (Person p in sortedListByName)
            {
                p.info();
            }
            Console.WriteLine();

            int age = listOfPeople.Min(x => x.age);
            Console.WriteLine("Najmłotsza osoba ma wiek: " + age);

            bool isLegalAge = listOfPeople.All(x => x.age < 18);
            Console.WriteLine("Czy wszystkie osoby są pełnoletnie " + isLegalAge);
        }
    }
}
