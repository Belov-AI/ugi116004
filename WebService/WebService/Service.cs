using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    public class Service : IEnumerable<User>
    {
        private List<User> users;

        public event Action<string> Log;

        public Service()
        {
            users = new List<User>();
        }

        public void LogMe(string message)
        {
            if (Log != null)
                Log(message);
        }

        public IEnumerator<User> GetEnumerator()
        {
            return users.GetEnumerator();
        }

        public void Login(User user)
        {
            if(!users.Contains(user))
            {
                users.Add(user);
                LogMe($"{user.Login} присоединился");
            }
        }

        public void Logout(User user)
        {
            if (users.Contains(user))
            {
                users.Remove(user);
                LogMe($"{user.Login} отсоединился");
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return users.GetEnumerator();
        }
    }
}
