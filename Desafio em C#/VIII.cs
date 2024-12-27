// 8: Escreva um programa que calcule a soma dos dígitos de um número.
using System;

class Program
{
    static void Main()
    {
        int num = 12345;
        Console.WriteLine($"A soma dos dígitos de {num} é {SumOfDigits(num)}");
    }

    static int SumOfDigits(int num)
    {
        int sum = 0;
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}
