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
        private List<User> users = new List<User>();

        public IEnumerator<User> GetEnumerator()
        {
            return users.GetEnumerator();
        }

        public void Login(User user)
        {
            if(!users.Contains(user))
            {
                users.Add(user);
                Console.WriteLine($"> {user.Login} присоединился");
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return users.GetEnumerator();
        }
    }
}
