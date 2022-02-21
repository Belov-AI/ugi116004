using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    public sealed class VipUser : RegisteredUser
    {
        private long cardnumber;

        public VipUser(string login, string password, string email, long cardnumber) :
            base(login, password, email)
        {
            this.cardnumber = cardnumber;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Номер карты {cardnumber}");
        }
    }
}
