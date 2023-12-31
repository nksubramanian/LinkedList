using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class Sort
    {
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
                else if (second > first)
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

        public static List<int> MergeSort(List<int> originalList)
        {

            if (originalList.Count <= 1)
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
