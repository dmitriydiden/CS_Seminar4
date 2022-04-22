// Задача №4 Заполнить массив из k элементов нулями и единицами (0 и 1) 
using System;
Console.Clear();
Console.Write("Введите длину массива K: ");
int K = int.Parse(Console.ReadLine());
Console.WriteLine(string.Join(" ", array(K)));


int[] array(int L)
{
    int[] arr = new int[L];

    for (int i = 0; i < L; i++)
    {
        arr[i] = new Random().Next(2);
    }
    return arr;
}