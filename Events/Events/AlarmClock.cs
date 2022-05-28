using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class AlarmClock
    {
        public string Name;

        public event AlarmEventHandler Ring;

        protected virtual void OnRing(AlarmEventArgs e)
        {
            if(Ring != null)
            {
                Console.WriteLine($"{e.EventDescription}: Уже {e.Time.ToShortTimeString()}!");
                Ring(this, e);
            }
        }

        public void WakeUp(string description)
        {
            OnRing(new AlarmEventArgs() 
            { Time = DateTime.Now, EventDescription = description });
        }
    }
}
