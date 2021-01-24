using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Model
{
    class ArrayQueue<T>
    {
        private T[] items;

        private T Head => items[Count > 0 ? Count - 1 : 0];
        private T Tail => items[0];
        private int MaxCount;
        public int Count { get; private set; }

        public ArrayQueue(int size) 
        {
            MaxCount = size;
            items = new T[size];
            Count = 0;
        }
        public ArrayQueue(int size, T data)
        {
            if (size > 0)
            {
                MaxCount = size;
                items = new T[size];
                items[0] = data;
                Count = 1;
            }
            else throw new ArgumentOutOfRangeException("Размер очереди не может быть нулевым.");
        }
        public void Enqueue(T data) // Поставить (в конец) в очередь
        {
            // короткая версия c помощью Linq-а
            if (MaxCount > Count)
            {
                IEnumerable<T> result = (new T[] { data }).Concat(items).ToArray();
                T[] Temporary = result.ToArray();
                Count++;
                for (int i = 0; i < Count; i++)
                {
                    items[i] = Temporary[i];
                }
            }
            else throw new Exception("Массив заполнен.");

            /*if(MaxCount > Count)
            {
                T[] result = new T[MaxCount];
                result[0] = data;
                for (int i = 0; i < Count; i++)
                {
                    result[i + 1] = items[0];
                }
                items = result;
                Count++;
            }*/
        }
        public T Dequeue() // Извлечение (Первого) элемента из очереди
        {
            if (Count != 0)
            {
                T item = Head;
                Count--;
                return item;
            }
            else throw new Exception("Массив пуст.");
            
        }
        public T Peek() // Посмотреть первый элемент
        {
            if(Count > 0)
            {
                return Head;
            }
            else throw new Exception("Массив пуст.");
        }
    }
}
