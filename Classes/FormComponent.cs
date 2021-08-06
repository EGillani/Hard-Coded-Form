using System;

namespace Assi3.Classes
{
    public abstract class FormComponent
    {
        //fix later and that means update the SetValue function 
        public FormComponent _formComponent;
        protected int _minLength;
        protected string _requiredChar;
        private FormComponent _formComponent2;

        public FormComponent()
        {

        }

        protected FormComponent(FormComponent formComponent, int minLength)
        {
            this._formComponent = formComponent;
            this._minLength = minLength;
        }

        protected FormComponent(FormComponent formComponent, string requiredChar)
        {
            this._formComponent = formComponent;
            this._requiredChar = requiredChar;
        }

        protected FormComponent(FormComponent formComponent, FormComponent formComponent2)
        {
            this._formComponent = formComponent;
            this._formComponent2 = formComponent2;
        }

        public abstract string GetName();
        public abstract string GetValue();
        public abstract void SetValue(string value);
        public abstract bool HandleInput();
    }
}
