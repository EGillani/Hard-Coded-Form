using System;
using System.Collections.Generic;
using Assi3.Classes;

namespace Assi3 {
    public class Form 
    {
        private IState _state; 

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
            Console.WriteLine();
        }

        public List<FormComponent> GetComponentList()
        {
            return _formComponents;
        }
    }
}
