using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinkedListOperations;

namespace QueueOperations
{
    public class Queue
    {
        LinkedList queueList = new LinkedList();
        public int count;

        public void enQueue(int data)
        {
            queueList.insertAtEnd(data);
            count++;
        }

        public int deQueue()
        {
            count--;
            return queueList.removeAtFront();
        }

        public void display()
        {
            queueList.printAllNodes();
        }
    }
}
