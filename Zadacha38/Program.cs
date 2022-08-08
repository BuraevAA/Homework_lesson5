/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
Console.Clear();
Console.WriteLine("Введите колличество элеметов массива");
int n = Convert.ToInt32(Console.ReadLine());
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 21);
        Console.Write(array[i]);
        Console.Write(", ");
    }
}
void FindMaxMin(int[] list)
{
    int max = list[0];
    int min = list[0];
    for (int i = 0; i < list.Length; i++)
    {
        if(list[i] > max) max = list[i]; 
        else if (list[i] < min) min = list[i];
    }
    int difference = max - min;
    Console.WriteLine($"Максимальное число: {max}");
    Console.WriteLine($"Минимально число: {min}");
    Console.WriteLine($"Разница между максимальным и минимальным числом: {difference}");
}

int[] array = new int[5];
FillArray(array);
Console.WriteLine();
FindMaxMin(array);