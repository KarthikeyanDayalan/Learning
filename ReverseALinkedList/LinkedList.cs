using System;

namespace LinkedListOperations
{
    public class LinkedList
    {
        private Node head;
        private Node tail;
        private int listSize;

        public LinkedList()
        {
            head = tail = null;
            listSize = 0;
        }

        public void printAllNodes()
        {
            Node curr = head;
            while (curr != null)
            {
                Console.WriteLine(curr.data);
                curr = curr.next;
            }
        }

        public void insertAtBegin(int value)
        {
            Node newNode = new Node(value);
            newNode.data = value;
            if (head == null || tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
            listSize++;
        }

        public void insertAtMiddle(int pos, int value)
        {
            Node newNode = new Node(value);
            Node curr = head;
            int tempPos = 0;

            if (pos == 0)
            {
                insertAtBegin(value);
            }
            else if (pos == listSize)
            {
                insertAtEnd(value);
            }
            else if (pos < listSize && pos > 0)
            {
                while (curr != null)
                {
                    if ((pos - 1) == tempPos)
                    {
                        newNode.next = curr.next;
                        curr.next = newNode;
                        break;
                    }
                    tempPos++;
                    curr = curr.next;
                }
            }
            else
            {
                Console.WriteLine("Please Enter the position in the list range from 0 to {0}", listSize);
            }
        }

        public void insertAtEnd(int value)
        {
            Node newNode = new Node(value);

            if (head == null || tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
            listSize++;
        }

        public int findElementAtIndex(int pos)
        {
            if (pos == 0)
            {
                return head.data;
            }
            else if (pos == listSize - 1)
            {
                return tail.data;
            }
            else if (pos > 0 && pos < listSize)
            {
                Node curr = head;
                int tempPos = 0;
                while (curr != null)
                {
                    if (tempPos == pos)
                    {
                        return curr.data;
                    }
                    curr = curr.next;
                    tempPos++;
                }
                return -1;
            }
            else
            {
                Console.WriteLine("Please enter the position value between 0 to {0}", listSize - 1);
                return -1;
            }
        }

        public bool findElementByValue(int value)
        {
            Node curr = head;
            while (curr != null)
            {
                if (curr.data == value)
                {
                    return true;
                }
                curr = curr.next;
            }
            return false;
        }

        public int removeAtFront()
        {
            int value = head.data;
            head = head.next;
            return value;
        }

        public int removeAtEnd()
        {
            Node curr = head;
            Node previous = null;
            int value;
            if (curr.next == null)
            {
                value = curr.data;
                head = tail = null;          
            }
            else
            {
                while (curr.next != null)
                {
                    previous = curr;
                    curr = curr.next;
                }
                value = tail.data;
                tail = previous;
                previous.next = null;
            }
            return value;
        }

        public void removeAtMiddle(int pos)
        {
            Node curr = head;
            int tempPos = 0;
            if (pos < 0 || pos > listSize)
            {
                Console.WriteLine("Please enter hte node to delete from 1 to {0}",listSize);
            }
            else if (pos == 1)
            {
                removeAtFront();
            }
            else if (pos == listSize)
            {
                removeAtEnd();
            }
            else if (pos < listSize)
            {
                while (curr != null)
                {
                    if ((pos - 2) == tempPos)
                    {
                        curr.next = curr.next.next;
                        return;
                    }
                    curr = curr.next;
                    tempPos++;
                }
            }
        }

        public void removeByValue(int value)
        {
            Node curr = head;
            Node previous = null;
            while (curr != null)
            {
                if (curr.data == value)
                {
                    if (previous == null)
                    {
                        removeAtFront();
                    }
                    else
                    {
                        previous.next = curr.next;
                        return;
                    }
                }
                previous = curr;
                curr = curr.next;
            }
        }

        public void reverse()
        {
            Node previous = null;
            Node curr = head;
            Node Front = head;
            tail = head;
            while (curr != null)
            {
                Front = Front.next;
                curr.next = previous;
                previous = curr;
                curr = Front;
            }
            head = previous;
        }

        public void reverseDisplay()
        {
            Node curr = head;
            int[] arr = new int[listSize];
            int i = 0;
            while (curr != null)
            {
                arr[i] = curr.data;
                i++;
                curr = curr.next;
            }
            for (int j = listSize - 1; j >= 0; j--)
            {
                Console.WriteLine(arr[j]);
            }
        }
    }

    public class Node
    {
        public int data;
        public Node next;
        public Node(int val)
        {
            data = val;
            next = null;
        }
    }
}