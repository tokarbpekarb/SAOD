using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackSaodFirst
{
    class MyStack<T>
    {
        private T[] array;
        private int count;
        private int length = 10;

        public int Size { get => length;}
        public bool IsEmpty {
            get { return count == 0; } 
        }

        public MyStack()
        {
            array = new T[length];
        }
        public void Push(T item)
        {
            if(count < length)
            {
                array[count++] = item;
            }
            else
            {
                throw new Exception("StackOverflow");
            }
        }

        public T Pop()
        {
            if (!IsEmpty)
            {
                T item = array[--count];
                array[count] = default(T);
                return item;
            }
            else
            {
                return default(T);
                //throw new Exception("Stack is empty!");
            }
        }

        public T Peek()
        {
            if (!IsEmpty)
                return array[count - 1];
            else
            {
                return default(T);
                //throw new Exception("Stack is empty!");
            }
        }
    }
}
