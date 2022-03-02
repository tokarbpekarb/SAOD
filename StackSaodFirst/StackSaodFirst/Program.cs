using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackSaodFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            TestStackMethod();
            Console.ReadLine();
        }
        public static void TestStackMethod()
        {
            MyStack<string> stack = new MyStack<string>();

            Console.WriteLine(stack.Size);
            Console.WriteLine(stack.Peek());

            stack.Push("first");
            stack.Push("second");

            Console.WriteLine(stack.IsEmpty);
            Console.WriteLine(stack.Size);

            stack.Push("third");
            stack.Push("fourth");

            while (!stack.IsEmpty)
            {
                Console.WriteLine(stack.Peek());
                stack.Pop();
            }

            stack.Pop();
            Console.WriteLine(stack.IsEmpty);
        }
    }
}
