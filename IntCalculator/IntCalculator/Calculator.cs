using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntCalculator
{
    class Calculator
    {
        public int X;
        public int Y;

        public int GetSum() { return X + Y; }

        public int GetDifference() { return X - Y; }

        public int GetProduct() { return X * Y; }

        public int GetQuotient() { return X / Y; }

        public int GetRest() { return X % Y; }
    }
}
