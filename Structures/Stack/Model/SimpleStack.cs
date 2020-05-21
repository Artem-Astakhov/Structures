using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures.Stack.Model
{
    public class SimpleStack<T>
    {
        private List<T> items = new List<T>();
        public int Count => items.Count;
        
        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (Count > 0)
            {
                var item = items.LastOrDefault();
                items.Remove(item);
                return item;
            }
            else
            {
                throw new NullReferenceException("Пустой стек");
            }
        }

        public T Peek()
        {
            if (Count > 0)
            {
                return items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException("Пустой стек");
            }
        }

        public void Clear()
        {
            items.Clear();
        }

    }
}
