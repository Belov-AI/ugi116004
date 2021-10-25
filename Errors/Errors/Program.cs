using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число x");

            int x;

            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }
            
            Console.WriteLine("Введите целое число y");

            //var y = int.Parse(Console.ReadLine());

            int y;

            if(!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Ошибка ввода числа y");
                Console.ReadKey();
                return;
            }

            try
            {
                Console.WriteLine($"x / y = {x / y}");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
                   
                

            Console.ReadKey();
        }
    }
}
