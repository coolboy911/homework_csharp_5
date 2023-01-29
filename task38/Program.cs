// Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double randomDouble = new Random().Next(1,10);
Console.Clear();

double RandomDouble(int minBorder, int maxBorder)  // случайное дробное число в диапазоне
{
    double randomDouble = new Random().NextDouble() * (maxBorder - minBorder) + minBorder;
    return randomDouble;
}

double[] RandomArray(int lenght, int minBorder, int maxBorder) // массив из случайных чисел, вызов функции в функции
{
    double[] array = new double[lenght];
    for (int i = 0; i < lenght; i++) array[i] = RandomDouble(minBorder, maxBorder);
    return array;
}

void SumMinMax(double[] array) // решил сделать через void чтобы он выводил ещё и min и max чтобы проверять
{
    double min = array[0], max = array[0], total = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        else if (array[i] > max) max = array[i];
    }
    total = min + max;
    Console.WriteLine($"min = {min} ; max = {max}");
    Console.WriteLine($"min + max = {total}");
}


double[] randomArray = RandomArray(10, 1, 10);  // создаем массив с 10 элементов в диапазоне от 1 до 10
Console.WriteLine(string.Join(" ", randomArray));
SumMinMax(randomArray);
