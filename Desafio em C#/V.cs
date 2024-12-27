// 5: Implemente um algoritmo para encontrar o caminho mínimo em um labirinto.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[,] maze = {
            { 1, 0, 0, 0 },
            { 1, 1, 0, 1 },
            { 0, 1, 0, 0 },
            { 1, 1, 1, 1 }
        };
        if (SolveMaze(maze))
            Console.WriteLine("Caminho encontrado!");
        else
            Console.WriteLine("Caminho não encontrado.");
    }

    static bool SolveMaze(int[,] maze)
    {
        int N = maze.GetLength(0);
        int[,] sol = new int[N, N];
        if (SolveMazeUtil(maze, 0, 0, sol) == false)
        {
            return false;
        }
        PrintSolution(sol);
        return true;
    }

    static bool SolveMazeUtil(int[,] maze, int x, int y, int[,] sol)
    {
        int N = maze.GetLength(0);
        if (x == N - 1 && y == N - 1 && maze[x, y] == 1)
        {
            sol[x, y] = 1;
            return true;
        }
        if (IsSafe(maze, x, y))
        {
            if (sol[x, y] == 1)
                return false;
            sol[x, y] = 1;
            if (SolveMazeUtil(maze, x + 1, y, sol))
                return true;
            if (SolveMazeUtil(maze, x, y + 1, sol))
                return true;
            sol[x, y] = 0;
            return false;
        }
        return false;
    }

    static bool IsSafe(int[,] maze, int x, int y)
    {
        int N = maze.GetLength(0);
        return (x >= 0 && x < N && y >= 0 && y < N && maze[x, y] == 1);
    }

    static void PrintSolution(int[,] sol)
    {
        for (int i = 0; i < sol.GetLength(0); i++)
        {
            for (int j = 0; j < sol.GetLength(1); j++)
            {
                Console.Write(sol[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
