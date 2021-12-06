using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasssesAndObjects
{
    class Program
    {
        static int number = 1;

        static void Main(string[] args)
        {
            Console.WriteLine(number);
            Console.WriteLine(Person.Species);

            var peter = new Person();
            peter.Name = "Пётр";
            peter.Surname = "Иванов";
            peter.Age = 17;
            PrintPerson(peter);

            var ann = new Person() { Name = "Анна", Surname = "Сергеева", Age = 18 };
            PrintPerson(ann);

            Console.ReadKey();
        }

        static void PrintPerson(Person person)
        {
            Console.WriteLine($"{Person.Species}: {person.Name} {person.Surname}, возраст: {person.Age}");
        }
    }
}
