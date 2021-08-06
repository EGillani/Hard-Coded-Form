using System;
using System.Collections.Generic;
using Assi3.Classes;

namespace Assi3 {
    public class Form : FormComponent 
    {
        // this is the mediator

        private IState _state; 

        // should contain a list of FormComponents
        private List<FormComponent> _formComponents;

        public Form()
        {
            this._formComponents = new List<FormComponent>();
        }

        public void SetState(IState state)
        {
            this._state = state;
            this._state.Run();
        }

        public void AddComponent(FormComponent component)
        {
            this._formComponents.Add(component);
        }

        public void Print()
        {
            foreach (FormComponent component in this._formComponents)
            {
                Console.WriteLine($"{component.GetName()}: {component.GetValue()}");
            }
        }

        public List<FormComponent> GetComponentList()
        {
            return _formComponents;
        }


        // is there a better way to deal with these functions below ...?

        public override string GetName()
        {
            return null;
        }

        public override string GetValue()
        {
            return null;
        }

        public override void SetValue(string value)
        {
            return;
        }

        public override bool HandleInput(string input)
        {
            throw new NotImplementedException();
        }
    }
}
