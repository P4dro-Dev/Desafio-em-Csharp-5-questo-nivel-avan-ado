// 15: Implemente um algoritmo para encontrar o maior caminho em um grafo acíclico dirigido (DAG).
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[,] graph = {
            { 0, 5, 3, 0, 0, 0 },
            { 0, 0, 2, 6, 0, 0 },
            { 0, 0, 0, 7, 4, 2 },
            { 0, 0, 0, 0, -1, 1 },
            { 0, 0, 0, 0, 0, -2 },
            { 0, 0, 0, 0, 0, 0 }
        };
        int source = 1;
        LongestPath(graph, source);
    }

    static void LongestPath(int[,] graph, int src)
    {
        int V = graph.GetLength(0);
        bool[] visited = new bool[V];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < V; i++)
            if (!visited[i])
                TopologicalSort(graph, i, visited, stack);

        int[] dist = new int[V];
        for (int i = 0; i < V; i++)
            dist[i] = int.MinValue;
        dist[src] = 0;

        while (stack.Count > 0)
        {
            int u = stack.Pop();
            if (dist[u] != int.MinValue)
            {
                for (int v = 0; v < V; v++)
                {
                    if (graph[u, v] != 0 && dist[u] + graph[u, v] > dist[v])
                        dist[v] = dist[u] + graph[u, v];
                }
            }
        }

        PrintSolution(dist);
    }

    static void TopologicalSort(int[,] graph, int v, bool[] visited, Stack<int> stack)
    {
        visited[v] = true;
        for (int i = 0; i < graph.GetLength(0); i++)
            if (graph[v, i] != 0 && !visited[i])
                TopologicalSort(graph, i, visited, stack);
        stack.Push(v);
    }

    static void PrintSolution(int[] dist)
    {
        Console.WriteLine("Vértice \t Distância da Fonte");
        for (int i = 0; i < dist.Length; i++)
            Console.WriteLine($"{i} \t\t {dist[i]}");
    }
}
