using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    public class User
    {
        public string Login { get; set; }

        public User(string login)
        {
            Login = login;
        }

        public User() : this("Anonymous") { }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Пользователь {Login}");
        }
    }
}
