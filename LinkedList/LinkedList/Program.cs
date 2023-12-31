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
            var g = MergeSort(randomNumbers);

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

        static List<int> Combine(List<int> firstHalf, List<int> secondHalf)
        {
            int firstHalfIter = 0, secondHalfIter = 0;
            List<int> sortedList = new List<int>();

            while (firstHalfIter < firstHalf.Count || secondHalfIter < secondHalf.Count)
            {
                int? first = (firstHalfIter < firstHalf.Count) ? firstHalf[firstHalfIter] : null;
                int? second = (secondHalfIter < secondHalf.Count) ? secondHalf[secondHalfIter] : null;

                if (first == second)
                {
                    sortedList.Add((int)first);
                    sortedList.Add((int)second);
                    firstHalfIter++;
                    secondHalfIter++;
                }
                else if (first is null)
                {
                    sortedList.Add((int)second);
                    secondHalfIter++;
                }
                else if (second is null)
                {
                    sortedList.Add((int)first);
                    firstHalfIter++;
                }
                else if (first > second)
                {
                    sortedList.Add((int)second);
                    secondHalfIter++;
                }
                else if(second > first)
                {
                    sortedList.Add((int)first);
                    firstHalfIter++;
                }
            }

            return sortedList;
        }


        static void SplitList<T>(List<T> originalList, out List<T> firstHalf, out List<T> secondHalf)
        {
            int middleIndex = originalList.Count / 2;
            firstHalf = originalList.Take(middleIndex).ToList();
            secondHalf = originalList.Skip(middleIndex).ToList();
        }

        static List<int> MergeSort(List<int> originalList)
        {

            if(originalList.Count<=1)
            {
                return new List<int>(originalList);
            }
            else
            {
                int middleIndex = originalList.Count / 2;
                var firstHalf = originalList.Take(middleIndex).ToList();
                var secondHalf = originalList.Skip(middleIndex).ToList();
                var a = MergeSort(firstHalf);
                var b = MergeSort(secondHalf);
                return Combine(a, b);

            }


        }


    }
}