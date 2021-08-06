
namespace Assi3.Classes.Decorators
{
    class CharacterValidator : FormComponent
    {

        public CharacterValidator(FormComponent formComponent, string requiredChar) : base(formComponent, requiredChar)
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
            return false; 
        }

        public override void SetValue(string value)
        {
           base._formComponent.SetValue(value);
        }
    }
}
