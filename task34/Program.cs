// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая 
// покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetRandomArray(int lenght, int min, int max)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int CountEvenInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length ; i++)
    {
        if (array[i] % 2 == 0) count ++;
    }
    return count;
}

int[] array = GetRandomArray(10, 100, 999);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Колличество четных элементов: {CountEvenInArray(array)}");