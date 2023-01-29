// Разобраться с алгоритмом сортировки методом пузырька. 
// Реализовать невозрастающую сортировку.

int[] CreateRandomArray(int lenght, int min, int max)
{
    int[] RandomArray = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        RandomArray[i] = new Random().Next(min, max + 1);
    }
    return RandomArray;
}

void SortArray(int[] array)
{
    for (int i = 0; i < (array.Length - 1); i ++)
    {
        for (int j = 0; (j < array.Length - 1); j++)
        {
            if (array[j] < array[j+1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}

Console.Clear();
int[] randomArray = CreateRandomArray(lenght: 20, min: 1, max: 100);
Console.WriteLine(string.Join(" ", randomArray));
SortArray(randomArray);
Console.WriteLine(string.Join(" ", randomArray));
