using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_algorithm_comparison
{
    class QuickSort
    {
        public static void Quick_Sort(int[] args)
        {
            int size = args.Length;

            Sort(args, size);

            Console.WriteLine("QuickSort Sorted: ");
            DisplayElements.ShowElements(args, size);
        }

        public static void ShowArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

        }
        public static void Sort(int[] a, int n)
        {
            Sort(a, 0, n - 1);
        }

        private static void Sort(int[] a, int low, int up)
        {
            if (low >= up) // zero or one element in sublist
                return;
            int p = Partition(a, low, up);
            Sort(a, low, p - 1); // sort left sublist
            Sort(a, p + 1, up); // sort right sublist
        }
        private static int Partition(int[] a, int low, int up)
        {
            int temp, i, j, pivot;

            pivot = a[low];

            i = low + 1; //moves from left to right
            j = up; // moves from right to left

            while (i <= j)
            {
                while (a[i] < pivot && i < up)
                    i++;

                while (a[j] > pivot)
                    j--;

                if (i < j) // swap a[i] and a[j]
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
                else // found proper place for pivot
                    break;
            }

            // proper place for pivot is j
            a[low] = a[j];
            a[j] = pivot;

            return j;
        }
    }
}
