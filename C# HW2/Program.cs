// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void ArraySum(int number)
{
    int[] Array = number;
    int i = 0;
    int sum = 0;

    while (i < Array)
    {
        sum = sum + Array[i];
    }
    Console.WriteLine($"Сумма цифр в числе равна: {sum}");


}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

ArraySum(number);


// int[] array = {1,2,34,54,23,123,54,23};

// int n = array.Length;
// int find = 23;

// int index = 0;

// while (index < n)
// {

//     if(array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     //index = index + 1;
//     index++;
//}