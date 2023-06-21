Console.Clear();
int chislo(string message)
{
  Console.Write(message);
  int result = int.Parse(Console.ReadLine()!);
  return result;
}

int NaturalNumber(int n, int m)
{
  if (n == m) return n;
  else 
  Console.Write($"{NaturalNumber(n, m + 1)}, ");
  return m;
}

int n = chislo("Введите натуральное число: ");
if (n < 1)
{
  Console.WriteLine("Введите положительное число!");
  return;
}
Console.WriteLine(NaturalNumber(n, 1));

