// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber(string message = "ampty")
{
    if (message != "ampty")
    {
        Console.WriteLine(message);
    }
    int num = Convert.ToInt32(Console.ReadLine());
    return num;

}

void SumValueNumber(int number)
{    
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    Console.WriteLine(sum);
}


int num = ReadNumber("Введите целое число: ");
SumValueNumber(num);
