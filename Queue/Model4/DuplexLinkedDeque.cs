using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Model4
{
    class DuplexLinkedDeque<T>
    {
        private DuplexItem<T> Head;
        private DuplexItem<T> Tail;
        public int Count { get; private set; }

        public DuplexLinkedDeque() { }
        public DuplexLinkedDeque(T data)
        {
            SetHeadItem(data);
        }

        private void SetHeadItem(T data)
        {
            DuplexItem<T> item = new DuplexItem<T>(data);

            Head = item;
            Tail = item;
            Count = 1;
        }

        public void PushBack(T data)
        {
            if(Count == 0 )
            {
                SetHeadItem(data);
                return;
            }

            DuplexItem<T> item = new DuplexItem<T>(data);
            item.Next = Tail;
            Tail.Previous = item;
            Tail = item;
            Count++;

        }
        public void PushFront(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            DuplexItem<T> item = new DuplexItem<T>(data);
            item.Previous = Head;
            Head.Next = item;
            Head = item;
            Count++;
        }
        public T PopBack()
        {
            if (Count == 0) throw new Exception("Дек пуст.");

            DuplexItem<T> item = Tail;

            if(Count != 1)
            {
                Tail = Tail.Next;
                Tail.Previous = null;
            }
            
            Count--;

            return item.Data;
        }
        public T PopFront()
        {
            if (Count == 0) throw new Exception("Дек пуст.");

            DuplexItem<T> item = Head;

            if (Count != 1)
            {
                Head = Head.Previous;
                Head.Next = null;
            }
            Count--;

            return item.Data;
        }
        public T PeekBack()
        {
            if (Count == 0) throw new Exception("Дек пуст.");
            return Tail.Data;
        }
        public T PeekFront()
        {
            if (Count == 0) throw new Exception("Дек пуст.");
            return Head.Data;
        }
    }
}
