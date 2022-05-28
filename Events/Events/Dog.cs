using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Dog
    {
        public string Name;

        public void Bark(object sender, AlarmEventArgs e)
        {
            Console.WriteLine($"{Name}: Гав-гав!");
        }
    }
}
