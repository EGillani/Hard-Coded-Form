using System;
using Assi3.Classes;
using Assi3.Classes.Decorators;

namespace Assi3
{
    class StateContext {
        private Form form;

        public void Run(Form form) {
            this.form = form;

            // Set your State here & run it
            form.SetState(new InputState(form));
        }

        public Form GetForm() {
            return form;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            
            form.AddComponent(
                new MinLengthValidator(
                    new TextBox("Username"), 6
                )
            );
            form.AddComponent(
                new CharacterValidator(
                    new CharacterValidator(
                        new TextBox("Email"), "@"
                    ), "."
                )
            );
            form.AddComponent(
                new MinLengthValidator(
                    new TextBox("Real Name"), 2
                )
            );

            FormComponent password = new CharacterValidator(
                new MinLengthValidator(
                    new TextBox("Password"), 8
                ), "!"
            );
            form.AddComponent(password);

            form.AddComponent(
                new ValueMatchValidator(
                    new TextBox("Confirm Password"), password
                )
            );
            form.AddComponent(
                new NumberValidator(
                    new TextBox("Age")
                )
            );

            new StateContext().Run(form);
        }
    }
}
