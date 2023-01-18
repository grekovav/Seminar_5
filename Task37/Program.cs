/* 37. Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
*/
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
int[] newarray(int[] array)
{
    int newlength = (int)Math.Ceiling(array.Length / 2.0);
    int[] arr = new int[newlength];
    for (int i = 0; i < newlength; i++)
    {
        if (i < newlength - 1 || array.Length%2==0)
        {
            arr[i] = array[i] * array[array.Length - i - 1];
        }
        else
        {
            arr[i] = array[i];
        }
    }
    return arr;
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
int[] array = generateArray(number, -10, 10);
printArray(array);
int[] array2 = newarray(array);
printArray(array2);
