using System;

namespace VectorAlgebra
{
    public class Vector
    {
        public double X;
        public double Y;
        public double Z;

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(
                a.X + b.X,
                a.Y + b.Y,
                a.Z + b.Z);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(
                a.X - b.X,
                a.Y - b.Y,
                a.Z - b.Z);
        }

        public static Vector operator *(double k, Vector a)
        {
            return new Vector(k * a.X, k * a.Y, k * a.Z);
        }

        public static Vector operator *(Vector a, double k)
        {
            return k * a;
        }

        public static double operator *(Vector a, Vector b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }

        public static Vector operator ^(Vector a, Vector b)
        {
            return new Vector(
                a.Y * b.Z - a.Z * b.Y,
                a.Z * b.X - a.X * b.Z,
                a.X * b.Y - a.Y * b.X);
        }

        public override string ToString()
        {
            return $"({X}; {Y}; {Z})";
        }


    }
}
