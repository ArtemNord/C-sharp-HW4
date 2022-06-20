// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void SummNumber(int number)
{
    int result = number % 10;
    while (number != 0)
    {
        number = number / 10;
        result = result + (number % 10);
    }
    Console.WriteLine(result);
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

SummNumber(number);