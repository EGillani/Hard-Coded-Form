
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

        public override bool HandleInput(string input)
        {
            throw new System.NotImplementedException();
        }

        public override void SetValue(string value)
        {
            base._formComponent.SetValue(value);
        }
    }
}
