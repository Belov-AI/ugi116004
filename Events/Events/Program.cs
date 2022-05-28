using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main()
        {
            var ringer = new AlarmClock() { Name = "будильник" };
            var boy = new Person() { Name = "Ваня", Message = "Дай поспать!" };
            var girl = new Person() { Name = "Таня", Message = "Уже встаю..." };

            ringer.Ring += boy.Reply;
            ringer.Ring += girl.Reply;

            ringer.WakeUp("Пора вставать");

            ringer.Ring -= boy.Reply;
            ringer.WakeUp("Пора вставать");

            ringer.Ring += boy.Reply;

            var dog = new Dog();
            dog.Name = "Шарик";
            ringer.Ring += dog.Bark;

            ringer.WakeUp("Пора вставать");

            Console.ReadKey();
        }
    }
}
