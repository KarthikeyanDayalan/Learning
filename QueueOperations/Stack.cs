using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinkedListOperations;

namespace QueueOperations
{
    public class Stack
    {
        LinkedList stackList = new LinkedList();
        public int count;

        public void Push(int data)
        {
            stackList.insertAtEnd(data);
            count++;
        }

        public int Pop()
        {
            count--;
            return stackList.removeAtEnd();
        }

        public void display()
        {
            stackList.printAllNodes();
        }
    }
}
