using System.Drawing;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            List<int> randomNumbers = Enumerable.Range(1, 10)
                                               .Select(_ => random.Next(10, 100))
                                               .ToList();
            var g = Sort.MergeSort(randomNumbers);

            LinkedListImp linkedListImp = new LinkedListImp();
            linkedListImp.AddNodeAtEnd(1);
            linkedListImp.AddNodeAtEnd(0);
            linkedListImp.AddNodeAtEnd(1);
            linkedListImp.AddNodeAtEnd(4);
            linkedListImp.AddNodeAtBeginning(4);
            linkedListImp.PrintAll();
            bool res = linkedListImp.IsPalindrome();
            Console.WriteLine(res);

        }

    }
}