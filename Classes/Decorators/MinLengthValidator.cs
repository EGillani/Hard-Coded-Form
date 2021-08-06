namespace Assi3.Classes.Decorators
{
    public class MinLengthValidator : FormComponent
    {
        string _requiredChar;
        int _minLength;

        //public MinLengthValidator(FormComponent formComponent, string requiredChar) : base(formComponent, requiredChar)
        //{
        //    base._formComponent = formComponent;
        //    this._requiredChar = requiredChar;
        //}

        //public MinLengthValidator(FormComponent formComponent, int minLength, string requiredChar) : base(formComponent, minLength, requiredChar)
        //{
        //    base._formComponent = formComponent;
        //    this._requiredChar = requiredChar;
        //    this._minLength = minLength;
        //}

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
