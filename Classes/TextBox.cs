﻿namespace Assi3.Classes
{
    class TextBox : FormComponent
    {
        // the concrete component
        private string _name;
        private string _value;

        public TextBox(string name): base(name)
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

        public override bool HandleInput()
        {
            return true; 
        }

        public override void SetValue(string value)
        {
            this._value = value;
        }
    }
}
