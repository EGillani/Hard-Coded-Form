namespace Assi3.Classes.Decorators
{
    public class MinLengthValidator : FormComponent
    {
        public MinLengthValidator(FormComponent formComponent, string requiredChar) : base(formComponent, requiredChar)
        {
            base._formComponent = formComponent;
        }

        public MinLengthValidator(FormComponent formComponent, int minLength, string requiredChar) : base(formComponent, minLength, requiredChar)
        {
            base._formComponent = formComponent;
        }

        public MinLengthValidator(FormComponent formComponent, int minLength) : base(formComponent, minLength)
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
    }
}
