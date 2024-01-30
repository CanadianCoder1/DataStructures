using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Trees_and_Linked_Lists
{
    //FIRST IN FIRST OUT FIFO
    public class MyQueue<T>
    {
        private Queue<T> queue = new Queue<T>();

        public bool IsEmpty => queue.Count == 0;

        public void Enqueue(T item)
        {
            queue.Enqueue(item);
        }

        public T Dequeue()
        {
            return queue.Dequeue();
        }

        public T Peek()
        {
            return queue.Peek();
        }
    }
}
