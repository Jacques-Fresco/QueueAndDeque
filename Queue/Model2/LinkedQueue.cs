using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Model2
{
    public class LinkedQueue<T>
    {
        public Item<T> Head;
        public Item<T> Tail;

        public int Count { get; private set; }
        public LinkedQueue() { }
        private void SeatHeatItem(T data)
        {
            Item<T> item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }
        public LinkedQueue(T data)
        {
            SeatHeatItem(data);
        }
        public void Enqueue(T data)
        {
            if(Count == 0)
            {
                SeatHeatItem(data);
                return;
            }

            Item<T> item = new Item<T>(data);
            item.Next = Tail;
            Tail = item;
            Count++;
        }
        public T Dequeue()
        {
            if (Count == 0) throw new Exception("Массив пуст.");

            T data = Head.Data;
            Head = Head.Next;
            Count--;
            return data;
            
        }
        public T Peek()
        {
            return Head.Data;
        }
    }
}
