// Задача 3. Написать программу, которая на входе принимает число N, а на выходе выдает произведение чисел от 1 до N.
using System;
Console.Clear();
Console.Write("Введите число N: ");
Console.WriteLine(multiplication(int.Parse(Console.ReadLine())));

int multiplication(int number)
{
    int multi=1;
    for(int i=1; i<= number; i++)
    {
        multi = multi * i;
    }
    return multi;
}