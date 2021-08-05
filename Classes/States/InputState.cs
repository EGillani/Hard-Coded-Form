using System.Collections.Generic;

namespace Assi3.Classes
{
    class InputState : IState
    {
        private Form _form;

        public InputState(Form form)
        {
            this._form = form;
        }

        public void Run()
        {
            // process user input using the _form's list of formcomponents
            List<FormComponent> componets =_form.GetComponentList();

            // TO-DO

            // when input has been processed, switch states
            _form.SetState(new DoneState(_form));
        }
    }
}
