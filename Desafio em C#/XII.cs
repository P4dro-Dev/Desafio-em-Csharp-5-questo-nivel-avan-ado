// 12 Escreva um programa que calcule o fatorial de um número usando recursão.
using System;

class Program
{
    static void Main()
    {
        int num = 5;
        Console.WriteLine($"O fatorial de {num} é {Factorial(num)}");
    }

    static int Factorial(int n)
    {
        if (n == 0)
            return 1;
        return n * Factorial(n - 1);
    }
}
