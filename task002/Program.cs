// Задача №2. Написать программу, которая на вход принимает число выдает количество цифр в числе
using System;
Console.Clear();
Console.Write("Input number A: ");
Console.WriteLine($"В числе А - {amount(int.Parse(Console.ReadLine()))} цифр/ы.");

int amount(int number)
{
    int am = 1;
    for (int i = 10; number/i > 0; i = i * 10)
    {
        am++;
    }
    return am;
}
