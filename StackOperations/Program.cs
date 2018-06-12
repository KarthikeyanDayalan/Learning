using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack new_stack = new Stack();
            new_stack.Push(1);
            new_stack.Push(2);
            new_stack.Push(3);
            new_stack.Push(4);
            new_stack.Pop();
            new_stack.Push(5);
            new_stack.display();

            StackUsingQueue new_stackqueue = new StackUsingQueue();
            new_stackqueue.Push(1);
            new_stackqueue.Push(2);
            new_stackqueue.Push(3);
            new_stackqueue.Push(4);
            new_stackqueue.Pop();
            new_stackqueue.Push(5);
            new_stackqueue.display();
        }
    }
}
