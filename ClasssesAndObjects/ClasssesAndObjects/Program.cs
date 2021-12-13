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
            //PrintPerson(peter);
            peter.PrintInfo();

            var ann = new Person() { Name = "Анна", Surname = "Сергеева", Age = 18 };
            //PrintPerson(ann);
            ann.PrintInfo();

            Person.PrintSpecies();

            var persons = new[] { peter, ann };

            foreach (var person in persons)
                Console.WriteLine(person.FullName);

            var jacob = new Person() { Name = "Яков", Surname = "Сидоров"};
            try
            {
                jacob.Age = -20;
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            jacob.INN = 123456;

            //PrintPerson(jacob);
            jacob.PrintInfo();

            Console.ReadKey();
        }

        //static void PrintPerson(Person person)
        //{
        //    Console.WriteLine($"{Person.Species}: {person.Name} {person.Surname}, возраст: {person.Age}");
        //}
    }
}
