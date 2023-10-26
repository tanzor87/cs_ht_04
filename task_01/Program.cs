// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int MyPow(int number1, int number2)
{
    int result = 1;
    for (int i = 0; i < number2; i++)
    {
        result *= number1;
    }
    return result;
}

Console.WriteLine("Введите число, которое нужно возвести в степень: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, которое  будет являться степенью: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int numPow = MyPow(num1, num2);
Console.WriteLine($"{numPow}");
