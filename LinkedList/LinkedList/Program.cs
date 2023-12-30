namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListImp linkedListImp = new LinkedListImp();
            linkedListImp.AddNodeAtEnd(1);
            linkedListImp.AddNodeAtEnd(2);
            linkedListImp.AddNodeAtEnd(3);
            linkedListImp.AddNodeAtBeginning(0);
            linkedListImp.AddNodeAtBeginning(-1);
            linkedListImp.PrintAll();
            Console.WriteLine("The count is "+linkedListImp.GetLength());
            linkedListImp.DeleteNodeAtBeginning();
            Console.WriteLine("********************");
            linkedListImp.PrintAll();
            //Console.WriteLine("The count is " + linkedListImp.GetLength());
            //Console.WriteLine($"Does 3 exist "+linkedListImp.IsKeyExists(3));
            //Console.WriteLine($"Does 50 exist " + linkedListImp.IsKeyExists(50));
            Console.WriteLine("Last node "+linkedListImp.GetLastNode(2));
            linkedListImp.Reverse();
            Console.WriteLine("********************Reversed*******************");
            linkedListImp.PrintAll();
            Console.WriteLine("Hello, World!");
            linkedListImp.PrintReverse();

        }
    }
}