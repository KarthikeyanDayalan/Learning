using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinkedListOperations;

namespace StackOperations
{
    class Stack
    {
        LinkedList stackList = new LinkedList();

        public void Push(int data)
        {
            stackList.insertAtEnd(data);
        }

        public void Pop()
        {
            stackList.removeAtEnd();
        }

        public void display()
        {
            stackList.printAllNodes();
        }
    }
}
