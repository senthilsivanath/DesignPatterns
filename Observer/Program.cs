using Observer.Model;
using Observer.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.Attach(new HomeViewPresenter());
            order.BasketValue += 10;
            order.NumberOfProducts = 5;
        }
    }
}
