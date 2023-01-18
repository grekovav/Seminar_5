/* 34.  Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2   */
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
void SortArray(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Всего {numbers.Length} чисел, {count} из них чётные");

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
int[] array = generateArray(number, 100, 999);
printArray(array);
SortArray(array);
