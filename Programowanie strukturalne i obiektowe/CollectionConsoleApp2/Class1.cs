using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsoleApp2
{
    internal class TestCollection
    {
        public void TestArrayCollection()
        {
            TestCollection testCollection = new TestCollection();
            testCollection.TestArrayCollection();
            // deklarowanie zmiennej c++: typ, nazwa[rozmiar], np. int tab[5];
            // c#, 
            int[] arrayOfNumber = new int[10];
            arrayOfNumber[5] = 2222;

            Random random = new Random();
            for (int i = 0; i < arrayOfNumber.Length; i++)
            {
                arrayOfNumber[i] = random.Next() % 100;
            }

            /*for (int i = 0; i < arrayOfNumber.Length; i++)
            {
                Console.Write(arrayOfNumber[i] + ", ");
            }
            */

            // the same  

            foreach (int item in arrayOfNumber)
            {
                Console.Write(item + ", ");
            }

            int max = arrayOfNumber[0];

            foreach (int number in arrayOfNumber)
            {
                if (number > max)
                    max = number;
            }
            Console.WriteLine("Max w tablicy to: " + max);

        }

        public void TestObjectArrayCollection()
        {
            Number[] arrayWidthObjectNumber = new Number[5];
            //arrayWidthObjectNumber[2].ourNumber = 7;
            Random random = new Random();
            for (int i = 0; i < arrayWidthObjectNumber.Length; i++)
            {
                arrayWidthObjectNumber[i] = new Number();
                arrayWidthObjectNumber[1].ourNumber = random.Next() % 100;
            }

            foreach (Number number in arrayWidthObjectNumber)
            {
                Console.Write($"{number.ourNumber},");
            }

            int max = arrayWidthObjectNumber[0].ourNumber;

            foreach (Number number in arrayWidthObjectNumber)
            {
                if (number.ourNumber > max)
                    max = number.ourNumber;
            }
            Console.WriteLine("Max w tablicy to: " + max);
        }
        public void TestGeneric()
        {
            Number[] numbers = new Number[5];
            NumberFloat[] floatNumbers = new NumberFloat[5];
            NumberDouble[] doubleNumbers = new NumberDouble[5];

            NumberGeneric<int>  intGenericNumber = new NumberGeneric<int>();
            intGenericNumber.ourNumber = 7;

            NumberGeneric<int>[] intGenericNumbers = new NumberGeneric<int>[5];
            NumberGeneric<float>[] floatGenericNumbers = new NumberGeneric<float>[5];
            NumberGeneric<double>[] doubleGenericNumbers = new NumberGeneric<double>[5];
            NumberGeneric<byte>[] byteGenericNumbers = new NumberGeneric<byte>[5];

        }

        public void ListCollection()
        {
            int[] tab = new int[10];// nowa tablica: 10 elementow ;typ int
            //pracuje na tablicy
            // tab[4] = 2114

            List<int> listOfInts = new List<int>();
            listOfInts.Add(5);
            Console.WriteLine("Kolekcja ma " + listOfInts.Count + " elementów");

            for(int i = 0; i < new Random().Next(1,100); i++)
            {
                listOfInts.Add(new Random().Next(1,100));
            }
            foreach(int item in listOfInts)
            {
                Console.WriteLine("element: " + item);
            }


        }
    }

    class Number
    {
        public int ourNumber;
    }
    class NumberFloat
    {
        public float ourNumber;
    }
    class NumberDouble
    {
        public double ourNumber;
    }
    class Number<T>
    {
        public T ourNumber;
    }
    class NumberGeneric<T>
    {
        public T ourNumber;
    }
}
