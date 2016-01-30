using System;
using System.Collections;

namespace Stack
{
    public class Stack  
    {
       
        private readonly ArrayList _list = new ArrayList();

        public void Push(object obj)
        {
            if (obj != null)
                _list.Insert(0, obj);
            else
                throw new InvalidOperationException("The object is null");

           
        }

        public object Pop()
        {
            if (_list.Count == 0) throw new InvalidOperationException("The list is empty");
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