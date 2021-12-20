using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasssesAndObjects
{
    public class Person
    {
        public readonly static string Species;
        public readonly static string LogFileName;

        public string Name;
        public string Surname;
        public int INN { get;}

        private int age;
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value > 0)
                    age = value;
                else
                    throw new ArgumentException("Возраст должен быть положительным числом");
            }
        }

        public string FullName
        {
            get
            {
                return Name + " " + Surname;
            }
        }

        public Person(string name, string surname, int age, int inn)
        {
            Name = name;
            Surname = surname;
            Age = age;
            INN = inn;
        }

        public Person(string name, string surname, int inn) : this(name, surname, 1, inn) { }

        public Person(int inn) : this("", "", inn) { }

        public Person() : this(0) { }

        static Person()
        {
            Species = "Homo Sapience";
            LogFileName = "log" + DateTime.Now.ToShortDateString() + ".txt";
        }

        ~Person()
        {
            Console.WriteLine($"--> Объект {FullName} уничтожен.");
        }

        public static void PrintSpecies()
        {
            Console.WriteLine(Species);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Species}: {FullName}, возраст: {Age}. ИНН: {INN}");
        }
    }
}
