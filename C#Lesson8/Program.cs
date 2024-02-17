// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;

if (N > 9)
    while (N > 0)
    {
        count = N % 10;
        Console.Write(count + ",");
        N = N / 10;
    }
else
{
    Console.WriteLine("Меньше двух цифр");
}