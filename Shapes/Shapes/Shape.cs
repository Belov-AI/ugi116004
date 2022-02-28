using System;
using System.Drawing;


namespace Shapes
{
    public abstract class Shape
    {
        public Color OutlineColor { get; set; }
        public Color FillColor { get; set; }

        public abstract void Draw();

        public abstract void PrintInfo();
    }
}
