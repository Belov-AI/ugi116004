using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variations
{
    class Hound : Dog
    {
        public double Rate;

        public Hound(string name, int age, double rate) :
            base("гончая", name, age)
        {
            Rate = rate;
        }

        public override string ToString()
        {
            return $"Гончая по кличке {Name}, возраст {Age}, рейтинг {Rate}";
        }
    }
}
