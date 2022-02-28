using System;
using System.Drawing;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Point TopLeft;

        private float width;
        public float Width
        {
            get { return width; }

            set
            {
                if (value < 0)
                    throw new ArgumentException("Отрицательная ширина");

                width = value;
            }
        }

        private float height;

        public float Height
        {
            get { return height; }

            set
            {
                if (value < 0)
                    throw new ArgumentException("Отрицательная высота");

                height = value;
            }
        }

        public Rectangle (Point p, float w, float h, Color outline, Color fill)
        {
            TopLeft = p;
            Width = w;
            Height = h;
            OutlineColor = outline;
            FillColor = fill;
        }

        public Rectangle(Point p, float w, float h) : this(p, w, h, Color.Black, Color.White) { }

        public override void Draw()
        {
            Console.Write("Рисуем ");
            PrintInfo();
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"прямоугольник с вершиной ({TopLeft.X}; {TopLeft.Y}) шириной {Width} и высотой {Height}");
            Console.WriteLine($"обводка {OutlineColor.Name}, заливка {FillColor.Name}\n");
        }
    }
}
