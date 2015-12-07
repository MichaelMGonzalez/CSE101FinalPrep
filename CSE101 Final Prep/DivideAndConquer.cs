using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE101_Final_Prep
{
    class DivideAndConquer
    {
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
