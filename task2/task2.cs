Console.Clear();
Console.Write("Введите число M (больше N): ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N (Меньше M): ");
int n = int.Parse(Console.ReadLine()!);

Sum(m, n);

void Sum(int m, int n)
{
    Console.Write(Summa(m - 1, n));
}

int Summa(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + Summa(m, n);
        return res;
    }
}