using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_algorithm_comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, size;

            Console.Write("Enter the size of elements: ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Random rand = new Random();
            for (i = 0; i < size; i++)
                a[i] = rand.Next(100, 999);

            Console.WriteLine("Original array: ");
            DisplayElements.ShowElements(a, size);
            Console.WriteLine();

            Console.WriteLine("Starting comparsion...");

            //BubbleSort(a);
            //HeapSort(a);
            //InsertionSort(a);
            MergeSort.Merge_Sort(a);
            QuickSort.Quick_Sort(a);
           // SelectionSort(a);
            
        }
    }
}
