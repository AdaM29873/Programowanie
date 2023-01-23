using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape.ConsolApp
{
    internal class Rectangle: Tetragon
    {
        protected double sideB;
        protected double sideA;

        public Rectangle(string name) : base (name,21,37,21,37)
        {
        }

        public Rectangle(string name,double sideA,double sideB) : base(sideA, sideB, sideA, sideB)
        { 
        }

        public double Area()
        {
            return sideA*sideB;
        }
    }
}
