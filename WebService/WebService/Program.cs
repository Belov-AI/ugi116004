using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    class Program
    {
        static void Main(string[] args)
        {
            var george = new User();
            george.Login = "George032";

            var kate = new User("Kate");

            var john = new RegisteredUser("John", "qwerty", "john@yandex.ru");

            var paul = new VipUser("Paul123", "456789", "paul@gmail.com", 2400569743981555);

            var admin = new Admin("Sergei", "admin2022", "sergei@mail.ru", 4);

            var users = new[] { george, kate, john, paul, admin};

            object obj = new object();

            RegisteredUser regUser = paul as RegisteredUser;

            VipUser vip = kate as VipUser;

            

            var service = new Service();

            var consoleLogger = new ConsoleLogger();
            service.Log += consoleLogger.Register;

            var fileLogger = new FileLogger("log.txt");
            service.Log += fileLogger.Register;

            foreach (var user in users)
                service.Login(user);

            Console.WriteLine();
            foreach (var user in service)
                user.PrintInfo();

            service.Logout(john);

            Console.WriteLine();
            foreach (var user in service)
                user.PrintInfo();

            Console.ReadKey();
        }
    }
}
