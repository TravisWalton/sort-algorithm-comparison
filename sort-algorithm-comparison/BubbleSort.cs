using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_algorithm_comparison
{
    class BubbleSort
    {
        public static void Bubble_Sort(int[] a)
        {
            int x, j, temp, swaps;

            for (x = a.Length - 2; x >= 0; x--)
            {
                swaps = 0;
                for (j = 0; j <= x; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        swaps++;
                    }
                }
                if (swaps == 0)
                    break;
            }
        }
        static int[] FillArray(int[] arr)
        {
            Random rand = new Random();
            for (int x = 0; x < arr.Length; x++)
                arr[x] = rand.Next(10, 99);
            return arr;
        }
        static void ShowArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
