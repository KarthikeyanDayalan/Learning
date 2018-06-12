using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QueueOperations;

namespace StackOperations
{
    class StackUsingQueue
    {
        Queue q1 = new Queue();
        Queue q2 = new Queue();
        Queue temp = new Queue();

        public void Push(int val)
        {
            q1.enQueue(val);
        }

        public int Pop()
        {
            while (q1.count > 1)
            {
                q2.enQueue(q1.deQueue());
            }
            temp = q1;
            q1 = q2;
            q2 = temp;
            return q2.deQueue();
        }

        public void display()
        {
            int[] display_array = new int[q1.count];
            while (q1.count > 0)
            {
                int a = q1.deQueue();
                display_array[q1.count] = a;
                q2.enQueue(a);
            }
            for (int i = 0; i < q2.count; i++)
            {
                Console.WriteLine(display_array[i]);
            }
            temp = q1;
            q1 = q2;
            q2 = temp;
        }
    }
}
