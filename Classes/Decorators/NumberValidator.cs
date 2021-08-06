using System;

namespace Assi3.Classes.Decorators
{
    public class NumberValidator : FormComponent
    {
        public NumberValidator(FormComponent formComponent) : base(formComponent)
        {
            base._formComponent = formComponent;
        }

        public override bool HandleInput()
        {
            if (Int32.TryParse(this.GetValue(), out int result))
                return true;
            else
                return false;

        }
    }
}
