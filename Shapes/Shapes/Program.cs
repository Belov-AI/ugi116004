using System;
using System.Drawing;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(new Point(10, 20), 100, 50);
            var circle = new Circle(new Point(25, 25), 40, Color.Blue, Color.LightBlue);

            var shapes = new Shape[] { rectangle, circle};

            foreach (var shape in shapes)
                shape.Draw();

            Console.ReadKey();
        }
    }
}
