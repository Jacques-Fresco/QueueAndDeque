using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Model
{
    class EasyQueue<T>
    {
        private List<T> items = new List<T>();
        private T Head => items.Last();
        private T Tail => items.First();

        public int Count => items.Count;

        public EasyQueue() { }
        public EasyQueue(T data)
        {
            items.Add(data);
        }
        public void Enqueue(T data) // Поставить (в конец) в очередь
        {
            items.Insert(0, data);
        }
        public T Dequeue() // Извлечение (Первого) элемента из очереди
        {
            items.Remove(Head);
            return Head;
        }
        public T Peek()
        {
            return Head;
        }
    }
}
