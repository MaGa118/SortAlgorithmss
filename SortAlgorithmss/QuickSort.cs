using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class QuickSort
    {
        public static void Perform(List<double> listToSort)
        {
            QuickSortRecursive(listToSort, 0, listToSort.Count - 1);
        }

        private static void QuickSortRecursive(List<double> list, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(list, low, high);

                QuickSortRecursive(list, low, pivotIndex - 1);
                QuickSortRecursive(list, pivotIndex + 1, high);
            }
        }

        private static int Partition(List<double> list, int low, int high)
        {
            double pivot = list[high]; 
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (list[j] <= pivot)
                {
                    i++;
                    Swap(list, i, j);
                }
            }

            Swap(list, i + 1, high); 
            return i + 1;
        }

        private static void Swap(List<double> list, int a, int b)
        {
            double temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
    }
}
