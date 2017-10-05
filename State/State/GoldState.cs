using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.State
{                               
    class GoldState : State
    {
        public GoldState(Account account)
            : base(account)
        {

        }


        protected override void notifyStateChanged()
        {
            if (this.Balance < 500)
            {
                account._state = new SilverState(account);
            }
        }
    }
}
