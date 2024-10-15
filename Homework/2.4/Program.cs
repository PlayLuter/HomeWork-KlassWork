using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 3, 34, 6, 18, 88, 7, 32, 10, 9 };

        Console.WriteLine("Исходный массив: ");
        PrintArray(array);

        BubbleSort(array);

        Console.WriteLine("Отсортированный массив: ");
        PrintArray(array);
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++) 
            for (int j = 0; j < n - 1; j++) 
                if (arr[j] > arr[j + 1]) 
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(" ", arr));
    }
}
