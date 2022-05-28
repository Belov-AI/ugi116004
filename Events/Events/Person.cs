using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Person
    {
        public string Name;
        public string Message;

        public void Reply(object sender, AlarmEventArgs e)
        {
            if (sender is AlarmClock alarm)
                Console.WriteLine($"{Name}: Эй, {alarm.Name}! " +
                    $"Уже {e.Time.ToShortTimeString()}? {Message}");
        }
    }
}
