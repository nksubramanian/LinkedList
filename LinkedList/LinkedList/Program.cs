namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListImp linkedListImp = new LinkedListImp();
            linkedListImp.AddNodeAtEnd(1);
            linkedListImp.AddNodeAtEnd(0);
            linkedListImp.AddNodeAtEnd(1);
            linkedListImp.AddNodeAtEnd(4);
            linkedListImp.AddNodeAtBeginning(4);
            linkedListImp.PrintAll();


             bool res = linkedListImp.IsPalindrome();
            Console.WriteLine("gggggggggggg");

        }
    }
}