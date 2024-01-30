using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Trees_and_Linked_Lists
{
    //LAST IN FIRST OUT LIFO
    public class MyStack<T>
    {
        private Stack<T> stack = new Stack<T>();

        public bool IsEmpty => stack.Count == 0;

        public void Push(T item)
        {
            stack.Push(item);
        }

        public T Pop()
        {
            return stack.Pop();
        }

        public T Peek()
        {
            return stack.Peek();
        }
    }
}
