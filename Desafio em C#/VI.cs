// 6: Escreva um programa que inverta uma string.
using System;

class Program
{
    static void Main()
    {
        string str = "Hello World";
        Console.WriteLine($"String invertida: {ReverseString(str)}");
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
