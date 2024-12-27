// 9: Implemente um algoritmo para resolver o problema das N rainhas.
using System;

class Program
{
    static void Main()
    {
        int N = 8;
        SolveNQueens(N);
    }

    static void SolveNQueens(int N)
    {
        int[,] board = new int[N, N];
        if (SolveNQueensUtil(board, 0) == false)
        {
            Console.WriteLine("Solução não existe");
            return;
        }
        PrintSolution(board);
    }

    static bool SolveNQueensUtil(int[,] board, int col)
    {
        int N = board.GetLength(0);
        if (col >= N)
            return true;
        for (int i = 0; i < N; i++)
        {
            if (IsSafe(board, i, col))
            {
                board[i, col] = 1;
                if (SolveNQueensUtil(board, col + 1))
                    return true;
                board[i, col] = 0;
            }
        }
        return false;
    }

    static bool IsSafe(int[,] board, int row, int col)
    {
        int i, j;
        int N = board.GetLength(0);
        for (i = 0; i < col; i++)
            if (board[row, i] == 1)
                return false;
        for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
            if (board[i, j] == 1)
                return false;
        for (i = row, j = col; j >= 0 && i < N; i++, j--)
            if (board[i, j] == 1)
                return false;
        return true;
    }

    static void PrintSolution(int[,] board)
    {
        int N = board.GetLength(0);
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N[_{{{CITATION{{{_1{](https://github.com/mungiu/SEM4_ADS_Recursion/tree/6d54839dcd06e71fda370fbd51223ff0e0f87e11/SEM$_ADS_RecursionANDbacktracking_NQueensSolver%2FProgram.cs)[_{{{CITATION{{{_2{](https://github.com/BigVikker/SapXep8Hau-BackTracking/tree/839b181b2ac988bf270740c7bc1f0ee6cd2e483f/TamHauTest%2FProgram.cs)