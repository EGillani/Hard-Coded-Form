namespace Assi3.Classes.Decorators
{
    public class ValueMatchValidator : FormComponent
    {
        public ValueMatchValidator(FormComponent formComponent, FormComponent formComponent2) : base(formComponent, formComponent2)
        {
            base._formComponent = formComponent;
            this._formComponent2 = formComponent2;
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
            if (this.GetValue().Equals(this._formComponent2.GetValue()))
                return true;
            else
                return false; 
        }
    }
}
