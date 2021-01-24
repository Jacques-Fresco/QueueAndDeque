using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Model4.DuplexLinkedDeque<int> linkedDeque = new Model4.DuplexLinkedDeque<int>();
            linkedDeque.PushFront(1); // Поставить (в конец) в очередь
            linkedDeque.PushFront(2);
            linkedDeque.PushFront(3);
            linkedDeque.PushBack(4);
            linkedDeque.PushBack(5);
            linkedDeque.PushFront(6);
            linkedDeque.PushBack(7);


            /*Console.WriteLine(linkedDeque.PopFront());
            Console.WriteLine(linkedDeque.PopFront());
            Console.WriteLine(linkedDeque.PopBack());
            Console.WriteLine(linkedDeque.PopBack());
            Console.WriteLine(linkedDeque.PopFront());*/

            Console.WriteLine(linkedDeque.PopBack());
            Console.WriteLine(linkedDeque.PopBack());
            Console.WriteLine(linkedDeque.PopBack());
            Console.WriteLine(linkedDeque.PopBack());
            Console.WriteLine(linkedDeque.PopBack());
            Console.WriteLine(linkedDeque.PopBack());
            Console.WriteLine(linkedDeque.PopBack());

            linkedDeque.PushFront(1); // Поставить (в конец) в очередь
            linkedDeque.PushFront(2);
            linkedDeque.PushFront(3);
            linkedDeque.PushBack(4);
            linkedDeque.PushBack(5);
            linkedDeque.PushFront(6);
            linkedDeque.PushBack(7);

            Console.WriteLine();

            Console.WriteLine(linkedDeque.PopBack());
            Console.WriteLine(linkedDeque.PopBack());
            Console.WriteLine(linkedDeque.PopBack());
            Console.WriteLine(linkedDeque.PopBack());
            Console.WriteLine(linkedDeque.PopBack());
            Console.WriteLine(linkedDeque.PopBack());
            Console.WriteLine(linkedDeque.PopBack());

            Console.ReadLine();

            Model3.EasyDeque<int> easyDeque = new Model3.EasyDeque<int>();
            easyDeque.PushFront(1); // Поставить (в конец) в очередь
            easyDeque.PushFront(2);
            easyDeque.PushFront(3);
            easyDeque.PushBack(40);
            easyDeque.PushBack(50);
            easyDeque.PushFront(600);
            easyDeque.PushBack(700);


            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PopBack());
            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PopBack());


            Console.ReadLine();

            Model.ArrayQueue<int> arrayQueue = new Model.ArrayQueue<int>(10);
            arrayQueue.Enqueue(10); // Поставить (в конец) в очередь
            arrayQueue.Enqueue(20);
            arrayQueue.Enqueue(30);
            arrayQueue.Enqueue(40);
            arrayQueue.Enqueue(50);
            arrayQueue.Enqueue(60);
            arrayQueue.Enqueue(70);
            arrayQueue.Enqueue(80);
            arrayQueue.Enqueue(90);
            arrayQueue.Enqueue(100);

            Console.WriteLine(arrayQueue.Dequeue()); // Извлечение (Первого) элемента из очереди
            Console.WriteLine(arrayQueue.Peek()); // Посмотреть первый элемент
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Peek());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Peek());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Peek());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Peek());
            arrayQueue.Enqueue(300);
            arrayQueue.Enqueue(310);
            arrayQueue.Enqueue(320);
            arrayQueue.Enqueue(330);
            arrayQueue.Enqueue(340);
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Peek());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Peek());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Peek());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Peek());
            Console.WriteLine(arrayQueue.Dequeue()); // извлекаем 100 - Count = 0;
            Console.WriteLine(arrayQueue.Peek());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Peek());
            Console.WriteLine(arrayQueue.Dequeue());

            arrayQueue.Enqueue(10); //Count++; Count = 1
            arrayQueue.Enqueue(20); //Count++; Count = 2
            arrayQueue.Enqueue(30); //Count++; Count = 3
            Console.WriteLine(arrayQueue.Peek()); // смотрим 10 - Count = 3
            Console.WriteLine(arrayQueue.Dequeue()); // извлекаем 10 - Count--; Count = 2
            Console.WriteLine(arrayQueue.Peek()); // смотрим 20
            Console.WriteLine(arrayQueue.Dequeue()); // извлекаем 20 - Count--; Count = 1
            Console.WriteLine(arrayQueue.Peek()); // смотрим 30
            Console.WriteLine(arrayQueue.Dequeue()); // извлекаем 30 - Count--; Count = 0

            //EasyQueue

            /*Model.EasyQueue<int> easyQueue = new Model.EasyQueue<int>();
            easyQueue.Enqueue(1);
            easyQueue.Enqueue(2);
            easyQueue.Enqueue(3);
            easyQueue.Enqueue(4);
            easyQueue.Enqueue(5);

            Console.WriteLine(easyQueue.Dequeue());
            Console.WriteLine(easyQueue.Peek());
            Console.WriteLine(easyQueue.Dequeue());*/

            Console.ReadLine();
        }
    }
}
