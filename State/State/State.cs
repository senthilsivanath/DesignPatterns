using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.State
{
    abstract class State : IState
    {
        abstract protected void notifyStateChanged();

        protected Account account;

        public State(Account account)
        {
            this.account = account;
        }

        private double balance;

        protected double Balance
        {
            get;
            set;
        }

        void IState.deposit(double amount)
        {
            this.Balance += amount;
            this.notifyStateChanged();
        }

        void IState.withdraw(double amount)
        {
            this.Balance -= amount;
            this.notifyStateChanged();
        }
    }
}
