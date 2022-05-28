using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    public class ConsoleLogger : Logger
    {
        public override void Register(string message)
        {
            Console.WriteLine($"> {DateTime.Now.ToLongTimeString()} {message}");
        }
    }
}
