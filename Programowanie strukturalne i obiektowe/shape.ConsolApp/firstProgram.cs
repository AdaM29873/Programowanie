using System;
using shape.ConsolApp;
namespace shape.ConsolApp
{
    internal class firstProgram
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(imie,21,2,2,2);
            rectangle.showInfo();
            Console.WriteLine();
            Rectangle secondRectangle = new Rectangle(54,99);
            secondRectangle.showInfo();
            Console.WriteLine();
            Square firstSquare = new Square();
            firstSquare.showInfo();
        }
    }
}
