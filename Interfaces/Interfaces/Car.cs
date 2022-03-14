using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Interfaces
{
    public class Car : IDivable
    {
        public string Name;

        public double Velocity { get; set; }

        public void Drive(double delta)
        {
            Velocity += delta;
        }

        public void Start()
        {
            Console.WriteLine("Машина: зажигание включено");  
        }

        public void Stop()
        {
            while(Velocity > 0)
            {
                Drive(-10);
                if (Velocity < 0) Velocity = 0;
            }
        }
    }
}
