using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures.LinkedList.Model
{
     public class Item<T>
    {
        private T data = default(T);
        /// <summary>
        /// Данные хранимые в списке
        /// </summary>
        public T Data
        {
            get { return data; }
            set 
            {
                if (value != null)
                {
                    data = value;
                }
            }
        }
        /// <summary>
        /// Следующий елемент списка
        /// </summary>
        public Item<T> Next { get; set; }

        public Item(T data)
        {
            Data = data;
        }
      
    }
}
