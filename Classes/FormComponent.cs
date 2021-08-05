namespace Assi3.Classes
{
    public abstract class FormComponent
    {
        protected FormComponent _formComponent;
        private int _minLength;
        private string _requiredChar;
        private FormComponent _formComponent1;
        private FormComponent _formComponent2;
        private string _name;
        private string _value;

        public FormComponent()
        {

        }

        protected FormComponent(FormComponent formComponent, int minLength, string requiredChar) 
        {
            this._formComponent = formComponent;
            this._minLength = minLength;
            this._requiredChar = requiredChar;
       
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

        protected FormComponent(FormComponent formComponent1, FormComponent formComponent2)
        {
            this._formComponent1 = formComponent1;
            this._formComponent2 = formComponent2;
        }

        public abstract string GetName();
        public abstract string GetValue();
        public abstract void SetValue(string value);

    }
}
