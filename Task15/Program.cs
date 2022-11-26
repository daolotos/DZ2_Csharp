using System;

Console.WriteLine("Введите цифру дня недели: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N <= 5)
{
    Console.WriteLine("нет, это не выходной");
    
}
else Console.WriteLine("да, это выходной");

