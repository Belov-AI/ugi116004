using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variations
{
    class Mammal
    {
        public readonly string Species;
        public int Age;

        public Mammal(string species, int age)
        {
            Species = species;
            Age = age;
        }

        public override string ToString()
        {
            return $"Животное вида {Species}, возраст {Age}";
        }
    }
}
