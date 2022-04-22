// Задача №4 Заполнить массив из 8 элементов нулями и единицами (0 и 1) 
using System;
Console.Clear();
int[] array = new int[8];
for (int i=0; i<array.Length; i++)
{
    array[i]=new Random().Next(0, 2);
    Console.Write(array[i] + " ");
}
