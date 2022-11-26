using System;

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 100)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}
while (N >= 1000)
{
    N = N / 10;
}
int b = N % 10;

Console.WriteLine("Третье число:" + b);

