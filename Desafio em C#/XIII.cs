// 13: Implemente um algoritmo para resolver o problema da mochila (knapsack problem) usando programação dinâmica.
using System;

class Program
{
    static void Main()
    {
        int[] weights = { 2, 3, 4, 5 };
        int[] values = { 3, 4, 5, 6 };
        int capacity = 5;
        Console.WriteLine($"Valor máximo que pode ser colocado na mochila: {Knapsack(weights, values, capacity)}");
    }

    static int Knapsack(int[] weights, int[] values, int capacity)
    {
        int n = weights.Length;
        int[,] dp = new int[n + 1, capacity + 1];

        for (int i = 0; i <= n; i++)
        {
            for (int w = 0; w <= capacity; w++)
            {
                if (i == 0 || w == 0)
                    dp[i, w] = 0;
                else if (weights[i - 1] <= w)
                    dp[i, w] = Math.Max(values[i - 1] + dp[i - 1, w - weights[i - 1]], dp[i - 1, w]);
                else
                    dp[i, w] = dp[i - 1, w];
            }
        }

        return dp[n, capacity];
    }
}
