using System;

namespace Assi3.Classes
{
    public abstract class FormComponent
    {
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
        public FormComponent GetFormComponent()
        {
            return this._formComponent;
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
            if (this._formComponent._formComponent != null)
                this._formComponent._formComponent.SetValue(value);
        }

        public abstract bool HandleInput();
    }
}
