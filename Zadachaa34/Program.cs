/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
Console.Clear();
Console.WriteLine("Введите колличество элеметов массива");
int n = Convert.ToInt32(Console.ReadLine());
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i]);
        Console.Write(", ");
    }
}
void FindCount(int[] list)
{
    int count = 0;
    for (int i = 0; i < list.Length; i++)
    {
        if(list[i] % 2 ==0) count = count + 1; 
    }
    Console.WriteLine($"Количество четных чисел в массиве: {count}");
}

int[] array = new int[n];
FillArray(array);
Console.WriteLine();
FindCount(array);
