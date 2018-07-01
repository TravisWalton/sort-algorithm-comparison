using System;

public static class DisplayElements
{
    public static void ShowElements(int[] arr, int size)
	{
        for (int i = 0; i < size; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}
