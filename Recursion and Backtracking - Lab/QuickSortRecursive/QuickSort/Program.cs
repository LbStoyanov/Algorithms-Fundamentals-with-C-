﻿namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {9,2,4,6};

            var result = SortArray(arr,0,arr.Length);

            Console.WriteLine(String.Join(", ",arr));
        }
public int[] SortArray(int[] array, int leftIndex, int rightIndex)
{
    var i = leftIndex;
    var j = rightIndex;
    var pivot = array[leftIndex];

    while (i <= j)
    {
        while (array[i] < pivot)
        {
            i++;
        }
        
        while (array[j] > pivot)
        {
            j--;
        }

        if (i <= j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
            j--;
        }
    }
    
    if (leftIndex < j)
        SortArray(array, leftIndex, j);

    if (i < rightIndex)
        SortArray(array, i, rightIndex);

    return array;
}