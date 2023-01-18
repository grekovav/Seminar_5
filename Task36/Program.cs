/* 36. Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0  */
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
void oddPosition(int[] numbers)
{
    int sum = 0;
    for (int z = 1; z < numbers.Length; z+=2)
    {
    sum = sum + numbers[z];
    }
    Console.WriteLine($"Всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");
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
int[] array = generateArray(number, -99, 99);
printArray(array);
oddPosition(array);
