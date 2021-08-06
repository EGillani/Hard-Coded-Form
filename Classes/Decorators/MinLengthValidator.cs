namespace Assi3.Classes.Decorators
{
    public class MinLengthValidator : FormComponent
    {
        public MinLengthValidator(FormComponent formComponent, int minLength) : base(formComponent, minLength)
        {
            base._formComponent = formComponent;
            this._minLength = minLength; 
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
            if (this.GetValue().Length >= this._minLength)
                return true; 
            else
                return false; 
        }
    }
}
