// Алгоритм сортировки методом Min, Max. От Max к Min.

int[] arr = { 5, 8, 2, 3, 7, 4, 1, 9, 6, 0, 7, 7 };

void PrintArray(int[] array)
{
    int current = array.Length;
    for (int i = 0; i < current; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

void SortingArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int maxPos = i;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] > array[maxPos]) maxPos = j;
        }
        int temp = array[i];
        array[i] = array[maxPos];
        array[maxPos] = temp;
    }
}

PrintArray(arr);
SortingArray(arr);
PrintArray(arr);
