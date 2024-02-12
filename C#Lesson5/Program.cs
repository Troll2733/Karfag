//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно
// ли оно одновременно 7 и 23.


Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int Y = 23;
int X = 7;

// for (int i = 1; i<=N; i++)
// if (Y*i==N && X*i==N)
// {
// System.Console.WriteLine($"Кратно {i}");
// }
// else
// {
//     System.Console.WriteLine($"No {i}");
// }
if (N % Y == 0 && N % X == 0)
{
System.Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine("Не кратно");
}
