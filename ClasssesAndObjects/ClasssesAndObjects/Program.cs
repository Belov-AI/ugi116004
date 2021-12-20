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
            Console.WriteLine(Person.LogFileName);

            PrintSomePersonInfo("Николай", "Романов", 25, 12345);

            var peter = new Person(101);
            peter.Name = "Пётр";
            peter.Surname = "Иванов";
            peter.Age = 17;
            //PrintPerson(peter);
            peter.PrintInfo();

            var ann = new Person(102) { Name = "Анна", Surname = "Сергеева", Age = 18 };
            //PrintPerson(ann);
            ann.PrintInfo();

            Person.PrintSpecies();

            var persons = new[] { peter, ann };

            foreach (var person in persons)
                Console.WriteLine(person.FullName);

            var jacob = new Person("Яков", "Сидоров", 103);

            try
            {
                jacob.Age = -20;
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            jacob.Age = 30;
            

            //PrintPerson(jacob);

            jacob.PrintInfo();

            var george = new Person { Name = "George", Age = 5 };
            george.PrintInfo();

            Console.ReadKey();
        }

        static void PrintSomePersonInfo(string name, string surname, int age, int inn)
        {
            var person = new Person(name, surname, age, inn);
            person.PrintInfo();
        }
    }
}
