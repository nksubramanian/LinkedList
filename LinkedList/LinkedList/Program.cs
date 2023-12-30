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
            linkedListImp.DeleteNodeAtBeginning();
            Console.WriteLine("********************");
            linkedListImp.PrintAll();
            Console.WriteLine("Hello, World!");
        }
    }
}