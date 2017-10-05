using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Observer.Presenter
{
    interface IPresenter
    {
        void Notify(String field, Model.Model model);
    }
}
