/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
Console.Clear();
Console.WriteLine("Введите колличество элеметов массива");
int n = Convert.ToInt32(Console.ReadLine());
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-15, 15);
        Console.Write(array[i]);
        Console.Write(", ");
    }
}
void FindSumm(int[] list)
{
    int summ = 0;
    for (int i = 0; i < list.Length; i++)
    {
        if(i % 2 !=0) summ = summ + list[i]; 
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {summ}");
}

int[] array = new int[n];
FillArray(array);
Console.WriteLine();
FindSumm(array);
