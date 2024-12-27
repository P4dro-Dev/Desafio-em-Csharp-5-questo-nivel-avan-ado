// 14: Escreva um programa que converta um número decimal para binário.
using System;

class Program
{
    static void Main()
    {
        int num = 10;
        Console.WriteLine($"O número {num} em binário é {DecimalToBinary(num)}");
    }

    static string DecimalToBinary(int num)
    {
        if (num == 0)
            return "0";
        string binary = "";
        while (num > 0)
        {
            binary = (num % 2) + binary;
            num /= 2;
        }
        return binary;
    }
}
