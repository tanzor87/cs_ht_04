// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int ReadNumber(string message = "ampty")
{
    if (message != "ampty")
    {
        Console.WriteLine(message);
    }
    int num = Convert.ToInt32(Console.ReadLine());
    return num;

}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] ArrayAlements(int len)
{
    Console.WriteLine("Введите числа массива: ");
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = ReadNumber();
    }
    return array;
}

int lenArray = ReadNumber("Введите количество элементов массива: ");
int[] array = ArrayAlements(lenArray);
PrintArray(array);
