using System;
using System.Drawing;

namespace Shapes
{
    public class Circle : Shape
    {
        public Point Center;

        private float radius;
        public float Radius
        {
            get { return radius; }

            set
            {
                if (value < 0)
                    throw new ArgumentException("Отрицательный радиус");

                radius = value;
            }
        }

        public Circle(Point c, float r, Color outline, Color fill)
        {
            Center = c;
            Radius = r;
            OutlineColor = outline;
            FillColor = fill;
        }

        public Circle(Point c, float r) : this(c, r, Color.Black, Color.White) {}

        public override void Draw()
        {
            Console.Write("Рисуем ");
            PrintInfo();
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"круг радиуса {Radius} с центром в точке ({Center.X}; {Center.Y})");
            Console.WriteLine($"обводка {OutlineColor.Name}, заливка {FillColor.Name}\n");
        }
    }
}
