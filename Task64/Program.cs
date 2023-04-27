// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

if (n >= 1)
{
    Print(n);
}
else
{
    Console.WriteLine("Entered number is not prime");
}

void Print(int a)
{
    if (a > 1)
    {
        Console.Write($"{a}, ");
        Print(a - 1);
    }
    else
    {
        Console.Write($"{a}");
    }
}