
namespace Assi3.Classes.Decorators
{
    public class CharacterValidator : FormComponent
    {
        public CharacterValidator(FormComponent formComponent, string requiredChar) : base(formComponent, requiredChar)
        {
            base._formComponent = formComponent;
            this._requiredChar = requiredChar;
        }

        public override string GetName()
        {
            return base._formComponent.GetName();
        }

        public override string GetValue()
        {
            return base._formComponent.GetValue();
        }

        public override bool HandleInput()
        {
            if (this.GetValue().Contains(this._requiredChar))
                return true;
            else
                return false; 
        }

        public override void SetValue(string value)
        {
           base._formComponent.SetValue(value);
        }
    }
}
