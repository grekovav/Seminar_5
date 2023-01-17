/* 32. Напишите программу замены элементов массива: положительные 
элементы заменить на отрицательные и наоборот*/
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
int[] invertArray(int[] arrayToInvert)
{
    for (int i = 0; i < arrayToInvert.Length; i++)
    {
        arrayToInvert[i] = -arrayToInvert[i];
    }
    return arrayToInvert;
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
int length = getIntFromUser("Введите длину массива");
int[] array = generateArray(length, -100, 100);
printArray(array);
int[] invertedArray = invertArray(array);
printArray(invertedArray);
