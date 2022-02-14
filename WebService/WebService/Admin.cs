using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    public class Admin : RegisteredUser
    {
        private int accessLevel;

        public Admin(string login, string password, string email, int level) : 
            base(login, password, email)
        {
            accessLevel = level;
        }
    }
}
