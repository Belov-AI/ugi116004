using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variations
{
    class Dog : Mammal
    {
        public readonly string Breed;
        public string Name;

        public Dog(string breed, string name, int age) :
            base("собака", age)
        {
            Breed = breed;
            Name = name;
        }

        public override string ToString()
        {
            return $"Собака породы {Breed} по кличке {Name}, возраст {Age}";
        }
    }
}
