using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueueOperations
{
    class Queueusingstack
    {
        Stack s1 = new Stack();
        Stack s2 = new Stack();

        public void enQueue(int val)
        {
            s1.Push(val);
        }

        public void deQueue()
        {
            if (s2.count == 0)
            {
                while (s1.count > 0)
                {
                    s2.Push(s1.Pop());
                }
            }
            s2.Pop();
        }

        public void display()
        {
            Stack temp = new Stack();
            while (s2.count > 0)
            {
                int val = s2.Pop();
                Console.WriteLine(val);
                temp.Push(val);
            }
            while (temp.count > 0)
            {
                s2.Push(temp.Pop());
            }
            while (s1.count > 0)
            {
                int val = s1.Pop();
                Console.WriteLine(val);
                temp.Push(val);
            }
            while (temp.count > 0)
            {
                s1.Push(temp.Pop());
            }
        }
    }
}
