using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Presenter
{
    class HomeViewPresenter : IPresenter
    {
        public void Notify(String fieldChanged, Model.Model model)
        {
            Console.WriteLine( fieldChanged + " field got changed" + model.ToString());
        }
    }
}
