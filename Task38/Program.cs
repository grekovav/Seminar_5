/* 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76  */
double[] generateArray(int length, double start, double end)
{
    double[] result = new double[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = Convert.ToDouble(new Random().Next(-99, 99));
    }
    return result;
}
int getIntFromUser(string message)
{
    Console.WriteLine(message);
    int userInt = int.Parse(Console.ReadLine()!);
    return userInt;
}
void differenceMaxMin(double[] numbers)
{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;
    for (int z = 0; z < numbers.Length; z++)
    {
        if (numbers[z] > max)
        {
            max = numbers[z];
        }
        if (numbers[z] < min)
        {
            min = numbers[z];
        }
    }
    Console.WriteLine($"Всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
    Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
}
void printArray(double[] array)
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
int number = getIntFromUser("Введите количество элементов массива");
double[] array = generateArray(number, -99, 99);
printArray(array);
differenceMaxMin(array);
