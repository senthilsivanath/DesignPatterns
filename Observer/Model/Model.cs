using Observer.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Model
{
    abstract class Model
    {
       
        private List<IPresenter> presenters = new List<IPresenter>();

        public void Attach(IPresenter presenter)
        {
            presenters.Add(presenter);
        }

        public void Detach(IPresenter presenter)
        {
            presenters.Remove(presenter);
        }

        protected void Notify(String field)
        {
            foreach (var presenter in presenters)
            {
                presenter.Notify(field, this);
            }
        } 
    }
}
