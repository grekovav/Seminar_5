/* 33. Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве. */
int[] generateArray(int length, int start, int end)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end + 1);
    }
    return result;
}
int getIntFromUser(string message)
{
    Console.WriteLine(message);
    int userInt = int.Parse(Console.ReadLine()!);
    return userInt;
}
int FindNumber(int[] array, int number)
{
    int result = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            result = i;
            break;
        }
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
int number = getIntFromUser("Введите количество элементов массива");
int findNumber = getIntFromUser("Введите искомое число");
int[] array = generateArray(number, -100, 100);
printArray(array);
int result = FindNumber(array, findNumber);
if (result == -1)
{
    Console.WriteLine("Такого числа нет");
}
else
{
    Console.WriteLine($"Число {findNumber} есть в массиве по индексу {result}");
}
