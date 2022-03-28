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
            var paul = new Person() { Name = "Павел", Surname = "Сергеев", Age = 16 };

            var persons = new[] { ann, peter, john, paul };

            Array.Sort(persons);
            PrintPersonArray(persons);

            Console.WriteLine();

            Array.Sort(persons, new PersonComparerByAge());

            PrintPersonArray(persons);

            Console.ReadKey();
        }

        private static void PrintPersonArray(Person[] persons)
        {
            foreach (var person in persons)
                Console.WriteLine(person);
        }

    }
}
