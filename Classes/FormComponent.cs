using System;

namespace Assi3.Classes
{
    public abstract class FormComponent
    {
        //fix later and that means update the SetValue function 
        protected FormComponent _formComponent;
        protected int _minLength;
        protected string _requiredChar;
        protected FormComponent _formComponent2;
        protected string _name;

        public FormComponent(FormComponent formComponent)
        {
            this._formComponent = formComponent;
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

        protected FormComponent(string name)
        {
            this._name = name;
        }

        public virtual string GetName()
        {
            return this._formComponent.GetName();
        }

        public virtual string GetValue()
        {
            return this._formComponent.GetValue();
        }

        public virtual void SetValue(string value)
        {
            this._formComponent.SetValue(value);
        }

        //public abstract string GetName();
        //public abstract string GetValue();
        //public abstract void SetValue(string value);
        public abstract bool HandleInput();

        public FormComponent GetFormComponent()
        {
            return this._formComponent;
        }
        
    }
}
