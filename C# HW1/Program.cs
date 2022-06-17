// Напишите программу с циклом, которая принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В.

void Exponentiation(int number0, int number1)
{
    int result = number0;
    for (int i = 1; i < number1; i++)
    {
        result = result * number0;
    }
    
    //double result = Math.Pow(number0, number1); - Если не цикл, то можно решить так.

    Console.WriteLine($"Ответ: {result}");
}

Console.Write ("Введите число А: ");
int number0 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число B: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Exponentiation(number0, number1);