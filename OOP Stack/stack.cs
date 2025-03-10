using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjenaviAssignment
{
    public class Stack
    {
        private List<object> _elements = new List<object>();

        // Push method to add an object to the stack
        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Cannot push null onto the stack.");
            }
            _elements.Add(obj);
        }

        // Pop method to remove and return the top object from the stack
        public object Pop()
        {
            if (_elements.Count == 0)
            {
                throw new InvalidOperationException("Cannot pop from an empty stack.");
            }
            var topElement = _elements[_elements.Count - 1];
            _elements.RemoveAt(_elements.Count - 1);
            return topElement;
        }

        // Clear method to remove all objects from the stack
        public void Clear()
        {
            _elements.Clear();

        }
    }
}
