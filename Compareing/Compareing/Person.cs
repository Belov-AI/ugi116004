using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compareing
{
    public class Person : IComparable<Person>
    {
        public string Name;
        public string Surname;

        private int age;
        public int Age
        {
            get { return age; }

            set
            {
                if (value < 0)
                    throw new ArgumentException();

                age = value;
            }
        }

        public int CompareTo(Person other)
        {
            if (Surname == other.Surname)
                return Name.CompareTo(other.Name);

            return Surname.CompareTo(other.Surname);
        }

        public override string ToString()
        {
            return $"{Surname} {Name}, {Age} лет";
        }
    }
}
