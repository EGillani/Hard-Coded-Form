using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3.Classes
{
    class DoneState : IState
    {
        private Form _form;

        public DoneState(Form form)
        {
            this._form = form;
        }
        public void Run()
        {
            // if user input = print
            _form.Print();

            // if user input = exit
            // then exit 
        }
    }
}
