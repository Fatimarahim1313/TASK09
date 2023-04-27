// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Enter M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

if (m > n)
{
    Console.WriteLine("M greater then N");
}
else
{
   int sum = Sum(m, n);
   Console.WriteLine($"{sum}");
}

int Sum(int a, int b)
{
    int s = a;
    if (a < b)
    {
        s += Sum(a + 1, b);
    }
    return s;
}
