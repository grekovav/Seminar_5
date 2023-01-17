// 31. Задайте массив из 12 элементов, заполненный случайными
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и
// положительных элементов массива.
int[] generateArray(int length, int start, int end)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end + 1);
    }
    return result;
}
void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
/*int getSumOfPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}
int getSumOfNegative(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}*/
// flag = 1 - положительные; flag = -1 - отрицательные
int getSumOfPositiveOrNegative(int[] array, int flag = 1)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] * flag > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] array = generateArray(12, -9, 9);
printArray(array);
/*int sumOfPositive = getSumOfPositive(array);
int sumOfNegative = getSumOfNegative(array);
Console.WriteLine($"Сумма положительных {sumOfPositive}");
Console.WriteLine($"Сумма отрицательных {sumOfNegative}");*/
int sumOfPositive = getSumOfPositiveOrNegative(array, 1);
int sumOfNegative = getSumOfPositiveOrNegative(array, -1);
Console.WriteLine($"Сумма положительных {sumOfPositive}");
Console.WriteLine($"Сумма отрицательных {sumOfNegative}");
