// Минимальное из 2

int min(int a, int b)
{
    if (a < b) return a;
    else return b;
}

Console.Write("MIN: ");
Console.WriteLine(min(23, 10));

// Макс из 3

int Max(int a, int b, int c)
{
    int max = 0;
    if (a > b) max = a;
    else max = b;
    if (max > c) return max;
    else return c;
}
Console.Write("MAX: ");
Console.WriteLine(Max(31, 55, 14));
