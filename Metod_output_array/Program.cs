// Метод вывода массива в строку с задаваемыми отступами
Console.Clear();
int[] array = new int[5];
for (int i = 0; i < 5; i++)
{
    array[i] = new Random().Next(10);
}
Console.WriteLine(String.Join(" ", array));
