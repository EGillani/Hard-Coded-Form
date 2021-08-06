using System.Collections.Generic;
using System;

namespace Assi3.Classes
{
    class InputState : IState
    {
        private Form _form;
        string input;
        bool isValid = true;

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
                //print name of component
                string componentName = comp.GetName();
                Console.WriteLine(componentName + ":");
                do
                {

                    Console.Write("> ");
                    //take in input from user 
                    input = Console.ReadLine();
                    
                    //nested one 
                    if(comp.GetFormComponent() != null)
                    {
                        //maybe move this into the set value FormComponent later for cleaner version
                        comp.GetFormComponent().SetValue(input);
                        isValid = comp.GetFormComponent().HandleInput();
                        //print message 
                        if (!isValid)
                        {
                            Console.WriteLine("Invalid Entry, try again:");
                            continue; 
                        }

                    }

                    //current level set 
                    comp.SetValue(input);

                    //check if the value is valid
                    isValid = comp.HandleInput();

                    //print message 
                    if(!isValid)
                        Console.WriteLine("Invalid Entry, try again:");

                } while (!isValid);

            }


            // when input has been processed, switch states
            _form.SetState(new DoneState(_form));
        }
    }
}
