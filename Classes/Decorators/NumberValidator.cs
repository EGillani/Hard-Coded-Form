


using System;

namespace Assi3.Classes.Decorators
{
    class NumberValidator : FormComponent
    {
        public NumberValidator(FormComponent formComponent) 
        {
            base._formComponent = formComponent;
        }

        public override string GetName()
        {
            return base._formComponent.GetName();
        }

        public override string GetValue()
        {
            return base._formComponent.GetValue();
        }

        public override void SetValue(string value)
        {
            base._formComponent.SetValue(value);
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
