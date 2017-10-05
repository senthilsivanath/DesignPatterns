using State.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Account
    {
        public IState _state { get; set; }

        public Account()
        {
            _state = new SilverState(this);
        }

        public void deposit(double amount)
        {
            _state.deposit(amount);
        }

        public void withdraw(double amount)
        {
            _state.withdraw(amount);
        }

        public void getStatus()
        {
          
            Console.WriteLine(_state.GetType().Name + "is the state");
        }
    }
}
