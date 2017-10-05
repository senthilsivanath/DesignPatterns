using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Model
{
    class Order : Model
    {

        private int numberOfProducts;

        public int NumberOfProducts
        {
            get { return numberOfProducts; }
            set
            {
                numberOfProducts = value;
                this.Notify("NumberOfProducts");
            }
        }

        private int basketValue;

        public int BasketValue
        {
            get { return basketValue; }
            set
            {
                basketValue = value;
                this.Notify("BasketValue");
            }
        }

    }
}
