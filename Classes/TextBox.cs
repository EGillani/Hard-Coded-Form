namespace Assi3.Classes
{
    class TextBox : FormComponent
    {
        // the concrete component
        private string _name;
        private string _value;

        public TextBox(string name)
        {
            this._name = name;
            this._value = "";
        }

        public override string GetName()
        {
            return this._name;
        }

        public override string GetValue()
        {
            return this._value;
        }

        public override bool HandleInput(string input)
        {
            throw new System.NotImplementedException();
        }

        public override void SetValue(string value)
        {
            this._value = value;
        }
    }
}
