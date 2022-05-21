using System;

namespace Closure
{
    class Program
    {
        static void Main()
        {
            double scalar = 3;
            Func<double, double> scale = x => x * scalar;

            Console.WriteLine(scale(5));

            var call = CallCount();

            call();
            call();
            call();
            call();
            call();

            var funcs = new Func<int>[3];
            //funcs[0] = () => 0;
            //funcs[1] = () => 1;
            //funcs[2] = () => 2;

            for (var i = 0; i < funcs.Length; i++)
                funcs[i] = () => i;

            foreach (var f in funcs)
                Console.WriteLine(f());

            Console.ReadKey();
        }

        static Action CallCount()
        {
            var count = 0;
            return () => Console.WriteLine($"Счётчик равен {++count}");
        }

    }
}
