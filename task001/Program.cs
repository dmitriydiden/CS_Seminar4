// Задача 1. Написать программу, которая на входе принимает число А, а на выходе выдает суммы чисел от 1 до А.
/*Вариант 1.
using System;
Console.Clear();
Console.Write("Введите А: ");
int A=int.Parse(Console.ReadLine());
Console.WriteLine(Summa(A));

int Summa(int number)
{
    int sum = 0;
    for(int i = 0; i<=number; i++)
    {
        sum +=i;
    }
    return sum;
}*/
//Вариант 2. Убираем необходимость ввода дополнительной переменной А.
using System;
Console.Clear();
Console.Write("Введите А: ");
//int A=int.Parse(Console.ReadLine());
Console.WriteLine(Summa(int.Parse(Console.ReadLine())));

int Summa(int number)
{
    int sum = 0;
    for(int i = 0; i<=number; i++)
    {
        sum +=i;
    }
    return sum;
}