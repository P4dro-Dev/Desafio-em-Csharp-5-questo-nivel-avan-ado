// 4:  Escreva um programa que conte o número de vogais em uma string.
using System;

class Program
{
    static void Main()
    {
        string str = "Hello World";
        Console.WriteLine($"Número de vogais: {CountVowels(str)}");
    }

    static int CountVowels(string str)
    {
        int count = 0;
        foreach (char c in str)
        {
            if ("aeiouAEIOU".IndexOf(c) >= 0)
                count++;
        }
        return count;
    }
}
