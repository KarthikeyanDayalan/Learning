using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue new_queue = new Queue();
            new_queue.enQueue(1);
            new_queue.enQueue(2);
            new_queue.enQueue(3);
            new_queue.enQueue(4);
            new_queue.deQueue();
            new_queue.enQueue(5);
            new_queue.display();

            Queueusingstack new_Queueusingstack = new Queueusingstack();
            new_Queueusingstack.enQueue(1);
            new_Queueusingstack.enQueue(2);
            new_Queueusingstack.enQueue(3);
            new_Queueusingstack.enQueue(4);
            new_Queueusingstack.deQueue();
            new_Queueusingstack.enQueue(5);
            new_Queueusingstack.display();
        }
    }
}
