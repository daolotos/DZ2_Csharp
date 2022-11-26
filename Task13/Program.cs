using System;

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 100)
{
    Console.WriteLine("Это не трехзначное число, попробуйте еще раз");
    return;
}
while (N >= 1000)
{
    N = N / 10;
}
int b = N % 10;

Console.WriteLine("Третье число:" + b);

