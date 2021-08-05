namespace Assi3.Classes.Decorators
{
    class ValueMatchValidator : FormComponent
    {
        public ValueMatchValidator(FormComponent formComponent1, FormComponent formComponent2) : base(formComponent1, formComponent2)
        {
            base._formComponent = formComponent1;
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
    }
}
