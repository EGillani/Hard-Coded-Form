namespace Assi3.Classes.Decorators
{
    public class MinLengthValidator : FormComponent
    {
        public MinLengthValidator(FormComponent formComponent, int minLength) : base(formComponent, minLength)
        {
            base._formComponent = formComponent;
            this._minLength = minLength; 
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
