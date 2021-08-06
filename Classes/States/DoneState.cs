using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3.Classes
{
    class DoneState : IState
    {
        private Form _form;
        string input;
        bool isValid = true;

        public DoneState(Form form)
        {
            this._form = form;
        }
        public void Run()
        {
            Console.WriteLine("\nYou're done! To confirm, here's what you wrote:\n");
            // if user input = print
            _form.Print();
            Console.WriteLine("\nType reset to reset, or ok to proceed\n");
            do
            {

                Console.Write("> ");
                //take in input from user 
                input = Console.ReadLine();

                if (input.Equals("reset"))
                {
                    //reset the form 
                    _form.SetState(new InputState(this._form));
                }
                else if (input.Equals("ok"))
                {
                    Console.WriteLine("\nType print to print the form, or exit to leave");
                    while(true)
                    {
                        Console.Write("> ");
                        input = Console.ReadLine();
                        if (input.Equals("print"))
                        {
                            // if user input = print
                            _form.Print();
                        }
                        else if (input.Equals("exit"))
                        {
                            System.Environment.Exit(0);
                        }

                    }

                }
                else
                {
                    Console.WriteLine("Invalid Entry, try again:");
                    isValid = false;
                }
            } while (!isValid);
        }
    }
}
