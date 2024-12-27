// 1: Implemente um algoritmo que encontre o k-ésimo menor elemento em um array desordenado.
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = { 7, 10, 4, 3, 20, 15 };
        int k = 3;
        Console.WriteLine($"O {k}-ésimo menor elemento é {KthSmallest(array, k)}");
    }

    static int KthSmallest(int[] arr, int k)
    {
        Array.Sort(arr);
        return arr[k - 1];
    }
}
