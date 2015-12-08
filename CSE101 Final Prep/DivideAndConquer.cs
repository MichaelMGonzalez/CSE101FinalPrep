using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE101_Final_Prep
{
    class DivideAndConquer
    {
        public const int NIL = -255;
        public static int FindMajorityElemLin( List<int> list)
        {
            List<int> subList = new List<int>();
            if(list.Count > 3)
            {
                for(int i = 0; i < list.Count-1; i+=2)
                    if (list[i] == list[i + 1])
                        subList.Add(list[i]);
                if (list.Count % 2 == 1)
                    subList.Add(list[list.Count - 1]);
                if( subList.Count*2 > list.Count/2 )
                    return FindMajorityElemLin(subList);
            }
            if (list.Count == 1 | ( list.Count == 2 && list[0] == list[1]))
                return list[0];
            if (list.Count == 3 && (list[0] == list[1] | list[0] == list[2]))
                return list[0];
            else if(list.Count == 3 &&  list[1] == list[2])
                return list[1];
            
            return NIL;
        }
        public static int FindMajorityElement( List<int> list )
        {
            if (list.Count > 3)
            {
                List<int> leftList = new List<int>();
                List<int> rightList = new List<int>();
                for (int i = 0; i < list.Count; i++)
                {
                    if (i < (list.Count / 2))
                        leftList.Add(list[i]);
                    else
                        rightList.Add(list[i]);
                }
                int majLeft = FindMajorityElement(leftList);
                int majRight = FindMajorityElement(rightList);
                if (majLeft == majRight)
                    return majRight;
                int rC = 0;
                int lC = 0;
                foreach(int elem in list)
                {
                    if (elem == majLeft)
                        lC++;
                    if (elem == majRight)
                        rC++;
                }
                if (rC > list.Count / 2)
                    return majRight;
                if (lC > list.Count / 2)
                    return majLeft;

            }
            else
                for (int i = 0; i < list.Count - 1; i++)
                    for (int j = i; j < list.Count; j++)
                        if (list[i] == list[j])
                            return list[i];
            return NIL;
        }
        public static void QuickSort(List<int> list, bool inPlace) {
            Random rng = new Random();
            if(inPlace)
            {
                QuickSort(list, 0, list.Count, rng);
                return;
            }
            if (list.Count <= 1)
                return;
            int pivot = rng.Next(list.Count);
            pivot = rng.Next(list.Count);
            pivot = list[pivot];
            List<int> smallerList = new List<int>();
            List<int> equalList = new List<int>();
            List<int> greaterList = new List<int>();
            foreach (int elem in list)
            {
                if (elem < pivot)
                    smallerList.Add(elem);
                else if (elem > pivot)
                    greaterList.Add(elem);
                else
                    equalList.Add(elem);
            }
            QuickSort(smallerList, false);
            QuickSort(greaterList, false);
            list.Clear();
            foreach (int elem in smallerList)
                list.Add(elem);
            foreach (int elem in equalList)
                list.Add(elem);
            foreach (int elem in greaterList)
                list.Add(elem);

        }
        public static void QuickSort(List<int> list, int start, int edge, Random rng) {
            if( edge - start == 1)
                return;
            int pivotI = rng.Next(edge);
            pivotI = rng.Next(edge);
            int wallS = start;
            int wallE = start+1;
            foreach (int elem in list)
            {
                Console.Write(elem + ", ");
            }
            Console.WriteLine();
            for( int i = start; i < edge; i++) {
                if (i > wallS && list[i] < list[pivotI] )
                {
                    Swap(list, wallS, i);
                    Swap(list, wallE, i);
                    wallS++;
                    wallE++;
                }
                else if (list[pivotI] == list[i])
                {
                    Swap(list, i, wallE);
                    wallE++;
                }
            }
            foreach (int elem in list)
            {
                Console.Write(elem + ", ");
            }
            Console.WriteLine(list);
            Console.WriteLine(pivotI);
            QuickSort(list, start, wallS, rng);
            QuickSort(list, wallE, edge, rng);

        }
        public static void Swap(List<int> list, int i, int j)
        {
            int swap = list[j];
            list[j] = list[i];
            list[i] = swap; 
        }
        public static int Selection(List<int> list, int k)
        {
            Random rng = new Random();
            int pivot = list[rng.Next(list.Count)];
            pivot = list[rng.Next(list.Count)];
            List<int> smallerList = new List<int>();
            List<int> equalList = new List<int>();
            List<int> greaterList = new List<int>();
            foreach (int elem in list)
            {
                if (elem < pivot)
                    smallerList.Add(elem);
                else if (elem == pivot)
                    equalList.Add(elem);
                else
                    greaterList.Add(elem);
            }
            if (k <= smallerList.Count)
                return Selection(smallerList, k);
            if (smallerList.Count < k && k <= equalList.Count + smallerList.Count)
                return pivot;
            return Selection(greaterList, k - equalList.Count - smallerList.Count);
        }
    }
}
