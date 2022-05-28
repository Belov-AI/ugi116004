using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class AlarmEventArgs : EventArgs
    {
        public DateTime Time;
        public string EventDescription;
    }
}
