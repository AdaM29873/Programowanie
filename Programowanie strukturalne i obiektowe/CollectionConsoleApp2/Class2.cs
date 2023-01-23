using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsoleApp2
{
    internal class TestListCollection 
    {
        public void FirstTest()
        {
            Random random = new Random();
            List<int> listOfInts = new List<int>();
            listOfInts.Add(random.Next(1, 11));

            for (int i = 0; i < 5; i++)
            {
                listOfInts.Add(random.Next(1, 11));
            }

            Console.WriteLine("Lista Intow");

            foreach (int element in listOfInts)
            {
                Console.Write(element + ",");
            }
            Console.WriteLine();

            List<double> listOfDoubles = new List<double>();
            for (int i = 0; i < 5; i++)
            {
                double number = random.NextDouble() * 10 + 1;
                number = Math.Round(number, 4);

                listOfDoubles.Add(number);

                Console.WriteLine();
            }
            Console.WriteLine("lista double: ");
            foreach (double element in listOfDoubles)
            {
                Console.WriteLine();
                Console.WriteLine(element + ";");

            }
            Console.WriteLine();

            int max = MaxFromAllTypes<int>(listOfInts, (int firstNumber, int secondNumber) =>
            {
                return firstNumber > secondNumber;
            });
            Console.WriteLine("Max w liscie int'OW" + max);

            //int maxInt = MaxFromAllTypes<int>(listOfInts);
            //Console.WriteLine("Max w liście int'ów " + maxInt);

            //double maxDouble = MaxFromAllTypes<double>(listOfDoubles);
            //Console.WriteLine("Max w liście double'ow " + maxDouble);

            double maxDouble = MaxFromAllTypes<double>(listOfDoubles, (double firstNumber, double secondNumber) => firstNumber > secondNumber);
            Console.WriteLine("max w liscie double" + maxDouble);


            // "=>" wyrazenie lambda

            List<int> newListOfInts = GetNewCollection<int>(listOfInts, x => { return x > 5; });
            Console.WriteLine("wieksze od 5:" + ",");
            foreach(int item in newListOfInts)
            {
                Console.WriteLine(item + ";");
            }
            Console.WriteLine();
            
            newListOfInts = GetNewCollection<int>(listOfInts, x =>  x %2 == 0);
            Console.WriteLine("parzyste int'y:" + ",");
            foreach (int item in newListOfInts)
            {
                Console.WriteLine(item + ";");
            }
            Console.WriteLine();

        } 
        
        public List<T> GetNewCollection<T>(List<T>list, Func<T,bool> check)
        {
            List<T> newCollection = new List<T>();
            foreach(T item in list )
            {    
                if(check(item))
                {
                    newCollection.Add(item);
                }
              
            }
            return newCollection;
        }
        private int MaxFromInts(List<int> list)
        {
            int max = list[0];

            foreach(int item in list)
            {
                if (item > max)
                    max = item;
            }   
            return max;
        }

        private double MaxFromDoubles(List<double> list)
        {
            double max = list[0];

            foreach (double item in list)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }

        private T MaxFromAllTypes<T>(List<T> list, Func<T,T,bool>check)
        {
            T max = list[0];

            foreach (T item in list)
            {
                if(check(item,max))
                {
                    max = item;
                }
                
                /*if(item is int)
                {
                    if (CheckInt(int.Parse(item.ToString()), int.Parse(max.ToString())))
                        max = item;
                }
                if (item is Double)
                {
                    if (CheckDouble(Double.Parse(item.ToString()), Double.Parse(max.ToString())))
                        max = item;
                }

                if (item > max)
                {
                    max = item;
                }
               */
            }
            return max;
        }

        private bool CheckInt(int firstNumber, int secondNumber)
        {
            return firstNumber > secondNumber;
        }
        private bool CheckDouble(double firstNumber, double secondNumber)
        {
            return firstNumber > secondNumber;
        }


    }
}
