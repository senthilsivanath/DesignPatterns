using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.State
{
    class SilverState : State
    {
        public SilverState(Account account) : base(account)
        {
            
        }

        protected override void notifyStateChanged()
        {
            if (this.Balance > 500)
            {
                account._state = new GoldState(account);
            }
        }
    }
}
