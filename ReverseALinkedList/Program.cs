
namespace LinkedListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList newList = new LinkedList();
            newList.insertAtBegin(5);
            newList.insertAtBegin(4);
            newList.insertAtBegin(3);
            newList.insertAtBegin(2);
            newList.insertAtEnd(1);
            newList.insertAtEnd(6);
            newList.insertAtEnd(8);
            newList.insertAtEnd(7);
            //newList.insertAtMiddle(8, 10);
            newList.printAllNodes(); //2,3,4,5,1,6,8,7

            System.Console.WriteLine(newList.findElementAtIndex(0));
            System.Console.WriteLine(newList.findElementAtIndex(7));
            System.Console.WriteLine(newList.findElementAtIndex(4));
            System.Console.WriteLine(newList.findElementByValue(7));
            System.Console.WriteLine(newList.findElementByValue(-1));

            newList.removeAtFront(); //3,4,5,1,6,8,7
            newList.removeAtEnd(); //3,4,5,1,6,8
            newList.removeAtMiddle(4); //3,4,5,6,8
            newList.removeByValue(8); //3,4,5,6
            newList.removeByValue(-1);
            newList.removeAtMiddle(-1);
            newList.printAllNodes();
            //newList.reverseDisplay();
            //newList.reverse();
            //newList.printAllNodes();
        }
    }
}
