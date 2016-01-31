using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    public class Stack  
    {
       
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("The object is null");

            _list.Insert(0, obj); 
        }

        public object Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("The list is empty");

            var removed = _list[0];
            _list.Remove(_list[0]);
            return removed;
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}