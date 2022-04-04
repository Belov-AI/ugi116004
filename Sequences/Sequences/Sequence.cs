using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Sequences
{
    public class Sequence
    {
        public IEnumerable<BigInteger> Fibonacci()
        {
            BigInteger a = 1;
            BigInteger b = 1;
            BigInteger c;

            yield return a;
            yield return b;

            while (true)
            {
                c = a + b;
                yield return c;
                (a, b) = (b, c);
            }
        }

        public IEnumerable<BigInteger> Factorial()
        {
            BigInteger n = 1;
            BigInteger f = 1;

            while (true)
            {
                yield return f;
                f *= n++;
            }
        }
    }
}
