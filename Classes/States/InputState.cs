using System.Collections.Generic;
using System;

namespace Assi3.Classes
{
    class InputState : IState
    {
        private Form _form;
        string input;
        bool keepRunning = true;

        public InputState(Form form)
        {
            this._form = form;
        }

        public void Run()
        {
            // process user input using the _form's list of formcomponents
            List<FormComponent> components =_form.GetComponentList();

            Console.WriteLine("Welcome to the Form.");
            //iterate through all the components
            foreach(FormComponent comp in components)
            {
                string componentName = comp.GetName();
                Console.WriteLine(componentName + ":");
                do
                {

                    Console.Write("> ");
                    input = Console.ReadLine();
                    keepRunning = comp.HandleInput(input);

                    if(keepRunning == true)
                        Console.WriteLine("Invalid shit");
                    //is invalid input 


                } while (keepRunning);

                //when its accurate set the value
                comp.SetValue(input);
            }


            // when input has been processed, switch states
            _form.SetState(new DoneState(_form));
        }
    }
}
