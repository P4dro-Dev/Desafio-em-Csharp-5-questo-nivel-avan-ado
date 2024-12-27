// 7: Implemente um algoritmo para encontrar o maior divisor comum (MDC) de dois números.
using System;

class Program
{
    static void Main()
    {
        int a = 56, b = 98;
        Console.WriteLine($"O MDC de {a} e {b} é {GCD(a, b)}");
    }

    static int GCD(int a, int b)
    {
        if (b == 0)
            return a;
        return GCD(b, a % b);
    }
}
