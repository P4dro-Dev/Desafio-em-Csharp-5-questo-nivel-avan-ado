// 3: Implemente um algoritmo para encontrar o maior subarray com soma máxima.
using System;

class Program
{
    static void Main()
    {
        int[] array = { -2, -3, 4, -1, -2, 1, 5, -3 };
        Console.WriteLine($"A soma máxima do subarray é {MaxSubArraySum(array)}");
    }

    static int MaxSubArraySum(int[] arr)
    {
        int maxSoFar = arr[0], maxEndingHere = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            maxEndingHere = Math.Max(arr[i], maxEndingHere + arr[i]);
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
        }
        return maxSoFar;
    }
}
