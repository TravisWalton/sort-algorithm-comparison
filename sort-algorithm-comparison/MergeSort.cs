using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_algorithm_comparison
{
    class MergeSort
    {
        private static void ShowArray(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Sort(int[] a, int n)
        {
            int[] temp = new int[n];
            Sort(a, temp, 0, n - 1);
        }
        private static void Sort(int[] a, int[] temp, int low, int up)
        {
            if (low == up) // only one element
                return;

            ShowArray(a, a.Length);

            int mid = (low + up)/ 2;

            Sort(a, temp, low, mid); // sort low to mid
            Sort(a, temp, mid + 1, up); //sort mid+1 to up

            // merge low - mid and mid+1 - up to temp low-up
            Merge(a, temp, low, mid, mid + 1, up);

            // copy temp low-up to a low-up
            Copy(a, temp, low, up);
        }

        private static void Merge(int[] a, int[] temp, int low1, int up1, int low2, int up2)
        {
            int i = low1;
            int j = low2;
            int k = low1;

            while ((i<=up1)&& (j<=up2))
            {
                if (a[i] <= a[j])
                    temp[k++] = a[i++];
                else
                    temp[k++] = a[j++];
            }

            while (i <= up1)
                temp[k++] = a[i++];
            while (j <= up2)
                temp[k++] = a[j++];
        }

        private static void Copy(int[] a, int[] temp, int low, int up)
        {
            for (int i = low; i <= up; i++)
                a[i] = temp[i];
        }

        public static void Merge_Sort(int[] args)
        {
            int size = args.Length;

            Sort(args, size);
            Console.WriteLine();

            Console.WriteLine("Sorted array is : ");
            DisplayElements.ShowElements(args, size);
            Console.WriteLine("Speed: ");
            Console.ReadLine();
        }
    }
}
