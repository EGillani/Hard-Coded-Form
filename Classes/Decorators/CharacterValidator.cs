
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
           bool isValid  = false;
            if (this.GetFormComponent() != null)
                isValid = this.GetFormComponent().HandleInput();
            else
                isValid = true; 

            if (this.GetValue().Contains(this._requiredChar) && isValid == true)
                return true;
            else
                return false; 
        }

    }
}
