using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compareing;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            var ann = new Person() { Name = "Анна", Surname = "Сергеева", Age = 18 };
            var peter = new Person() { Name = "Пётр", Surname = "Алексеев", Age = 17 };
            var john = new Person() { Name = "Иван", Surname = "Алексеев", Age = 18 };

            var persons = new[] { ann, peter, john };

            Array.Sort(persons);

            foreach (var person in persons)
                Console.WriteLine(person);

            Console.ReadKey();
        }


    }
}
