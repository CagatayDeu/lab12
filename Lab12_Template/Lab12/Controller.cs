using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab12
{
    class Controller : IController
    {

        IView view;
        IModel model;

        public void getRequestFromModel()
        {
            model.getRequest();
        }

        public void setModel(IModel m)
        {
            model = m;
        }

        public void setView(IView v)
        {
            view = v;
        }

        public void updateView(string input)
        {
            view.update(input);
        }
    }
}
