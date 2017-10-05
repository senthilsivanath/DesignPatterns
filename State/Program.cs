using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.getStatus();
            account.deposit(600.0d);
            account.getStatus();
            account.withdraw(150);
            account.getStatus();
        }
    }
}
