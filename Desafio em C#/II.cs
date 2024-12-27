// 2: Escreva um programa que verifique se uma string é um palíndromo.
using System;

class Program
{
    static void Main()
    {
        string str = "radar";
        Console.WriteLine($"A string '{str}' é um palíndromo? {IsPalindrome(str)}");
    }

    static bool IsPalindrome(string str)
    {
        int len = str.Length;
        for (int i = 0; i < len / 2; i++)
        {
            if (str[i] != str[len - i - 1])
                return false;
        }
        return true;
    }
}
