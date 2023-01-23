using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape.ConsolApp
{
    internal class Square: Rectangle
    {
        public Square(string name) : base(name, 10,10)
        {
        }
        public Square(string name ,double sideA) :base(name,sideA,sideA)
        {
        }
        

    }
}
