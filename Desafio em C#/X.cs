// 10: Implemente um algoritmo para encontrar o menor caminho em um grafo usando o algoritmo de Dijkstra.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[,] graph = {
            { 0, 10, 0, 0, 0, 0 },
            { 10, 0, 5, 0, 0, 0 },
            { 0, 5, 0, 20, 1, 0 },
            { 0, 0, 20, 0, 2, 2 },
            { 0, 0, 1, 2, 0, 3 },
            { 0, 0, 0, 2, 3, 0 }
        };
        int source = 0;
        Dijkstra(graph, source);
    }

    static void Dijkstra(int[,] graph, int src)
    {
        int V = graph.GetLength(0);
        int[] dist = new int[V];
        bool[] sptSet = new bool[V];

        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
            sptSet[i] = false;
        }

        dist[src] = 0;

        for (int count = 0; count < V - 1; count++)
        {
            int u = MinDistance(dist, sptSet);
            sptSet[u] = true;

            for (int v = 0; v < V; v++)
                if (!sptSet[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                    dist[v] = dist[u] + graph[u, v];
        }

        PrintSolution(dist);
    }

    static int MinDistance(int[] dist, bool[] sptSet)
    {
        int min = int.MaxValue, minIndex = -1;

        for (int v = 0; v < dist.Length; v++)
            if (!sptSet[v] && dist[v] <= min)
            {
                min = dist[v];
                minIndex = v;
            }

        return minIndex;
    }

    static void PrintSolution(int[] dist)
    {
        Console.WriteLine("Vértice \t Distância da Fonte");
        for (int i = 0; i < dist.Length; i++)
            Console.WriteLine($"{i} \t\t {dist[i]}");
    }
}
