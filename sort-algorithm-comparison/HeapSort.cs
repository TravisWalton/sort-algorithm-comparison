using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_algorithm_comparison
{
    class HeapSort
    {
        public static void Sort(int[] a, int n)
        {
            BuildHeap_BottomUp(a, n);
            //Console.WriteLine("After building the heap:");
            //ShowArray(a, n);

            int maxValue;
            while (n > 1)
            {
                maxValue = a[1];
                a[1] = a[n - 1]; //a[1] = a[n];
                a[n - 1] = maxValue; //a[n] = maxValue;
                n--;
                RestoreDown(1, a, n);
                //Console.WriteLine("Max value: " + maxValue + ". Next loop of RestoreDown:");
                //ShowArray(a, n);
            }
        }

        public static void BuildHeap_BottomUp(int[] arr, int n)
        {
            int i;
            for (i = n / 2; i >= 1; i--)
            {
                RestoreDown(i, arr, n);
            }
        }

        private static void RestoreDown(int i, int[] a, int n)
        {
            int k = a[i];
            int lchild = 2 * i, rchild = lchild + 1;

            while (rchild < n) //while(rchild <=n)
            {
                if (k >= a[lchild] && k >= a[rchild])
                {
                    a[i] = k;
                    return;
                }
                else if (a[lchild] > a[rchild])
                {
                    a[i] = a[lchild];
                    i = lchild;
                }
                else
                {
                    a[i] = a[rchild];
                    i = rchild;
                }
                lchild = 2 * i;
                rchild = lchild + 1;
            }

            //if number of nodes is even
            if (lchild == n - 1 && k < a[lchild])
            {
                a[i] = a[lchild];
                i = lchild;
            }
            a[i] = k;
        }

        public static void Heap_Sort(int[] args)
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
