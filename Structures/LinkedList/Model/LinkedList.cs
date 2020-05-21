using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures.LinkedList.Model
{
    public class LinkedList<T>:IEnumerable
    {
        public Item<T> Head { get; private set; }
        public  Item<T> Tail { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            Clear();
        }

        public LinkedList(T data)
        {
            var item = new Item<T>(data);
            SetHeadAndTail(item);
        }

        /// <summary>
        /// Добавление елемента
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            var item = new Item<T>(data);

            if(Tail != null)
            {
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(item);
            }
        }

        /// <summary>
        /// Удаление елемента
        /// </summary>
        /// <param name="data"></param>
        public void Delete(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head.Next;
                var previous = Head;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    previous = current;
                    current = current.Next;
                }
            }
        }

        /// <summary>
        /// Очистка данных
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        /// <summary>
        /// Добавление елемента в начало
        /// </summary>
        /// <param name="data"></param>
        public void AppendHead(T data)
        {
            var item = new Item<T>(data);
            item.Next = Head;
            Head = item;
            Count++;
        }


        /// <summary>
        /// Добавление между елементами
        /// </summary>
        /// <param name="target"></param>
        /// <param name="data"></param>
        public void InsertAfter(T target, T data)
        {
            var item = new Item<T>(data);
            var current = Head;

            while (current != null)
            {
                if (current.Data.Equals(target))
                {
                    var nextItem = current.Next;
                    current.Next = item;
                    item.Next = nextItem;
                    Count++;
                    return;
                }
                current = current.Next;
            }
        }

        private void SetHeadAndTail(Item<T> item)
        {
            Head = item;
            Tail = item;
            Count = 1;
        }

        /// <summary>
        /// Реализация перечисления списка
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
