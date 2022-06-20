// Напишите программу, которая задает массв из 8 элементов и выводит их на экран.

int [] Length = new int [8];

void Array(int [] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        Console.Write("Введите число: ");
        number[i] = Convert.ToInt32(Console.ReadLine());
    }
}
Array(Length);

void ArrayShow(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}

ArrayShow(Length);