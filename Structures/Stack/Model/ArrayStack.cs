using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures.Stack.Model
{
    public class ArrayStack<T>
    {
        T[] items;
        public int Count => items.Length;
        private int current = -1;
        private int size = 10;
        public ArrayStack(int size = 10)
        {
            items = new T[size];
            this.size = size;
        }

        public ArrayStack(T data, int size = 10) : this(size)
        {
            items[0] = data;
            current = 1;
        }

        public void Push(T data)
        {
            if (current < size)
            {
                current++;
                items[current] = data;              
            }
            else
            {
                throw new StackOverflowException("Стек переполнен");
            }
        }

        public T Pop()
        {
            if (current >= 0)
            {
                var item = items[current];
                current--;
                return item;
            }
            else
            {
                throw new StackOverflowException("ПУстой стек");
            }
        }

        public T Peek()
        {
            if (current >= 0)
            {
                var item = items[current];
                return item;
            }
            else
            {
                throw new StackOverflowException("ПУстой стек");
            }
        }
    }
}
