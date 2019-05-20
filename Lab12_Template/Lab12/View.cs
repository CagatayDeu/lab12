using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab12
{
    class View : IView
    {
        IView view = new View();

        public void update(string input)
        {
            view.update(input);
        }
    }
}
