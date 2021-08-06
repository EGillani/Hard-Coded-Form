
namespace Assi3.Classes.Decorators
{
    public class CharacterValidator : FormComponent
    {
        public CharacterValidator(FormComponent formComponent, string requiredChar) : base(formComponent, requiredChar)
        {
            base._formComponent = formComponent;
            this._requiredChar = requiredChar;
        }

        public override bool HandleInput()
        {
            if (this.GetValue().Contains(this._requiredChar))
                return true;
            else
                return false; 
        }

    }
}
