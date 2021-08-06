namespace Assi3.Classes.Decorators
{
    public class ValueMatchValidator : FormComponent
    {
        public ValueMatchValidator(FormComponent formComponent, FormComponent formComponent2) : base(formComponent, formComponent2)
        {
            base._formComponent = formComponent;
            this._formComponent2 = formComponent2;
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
