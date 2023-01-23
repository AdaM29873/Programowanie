using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape.ConsolApp
{

   
    internal class Tetragon //: Object
    {
        protected double sideA;
        protected double sideB;
        protected double sideC;
        protected double sideD;
        protected string name;
        public Tetragon(string name,double sideA,double sideB,double sideC, double sideD)
        {
            this.sideA = Math.Abs(sideA);
            this.sideB = Math.Abs(sideB);
            this.sideC = Math.Abs(sideC);
            this.sideD = Math.Abs(sideD);
            this.name = name;
        }
        public double Area()
        {
            return -1;
        }

        public double Perimeter()
        {
            return  sideA + sideB + sideC + sideD;
        }

        public void showInfo()
        {
            Console.WriteLine("info o prostokącie: ");
            Console.WriteLine("bok a: " + sideA + "||" + "bok b: " + sideB + "bok d: "+ "||"+ sideD + "||" + "bok c: " + sideC);
            Console.WriteLine("obwód: " + Perimeter());
            Console.WriteLine("pole: " + Area());
        }

    }
}
