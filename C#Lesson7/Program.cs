//  Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.WriteLine("Введите число не больше 99 и не больше 10: ");
int N = Convert.ToInt32(Console.ReadLine());
int right = N / 10;
int left = N % 10;
if (N <= 99 && N >= 10)
{
    if (right > left)
    {
        Console.WriteLine($"max ={right}");
    }
    else
    if (right == left)
    {
        Console.WriteLine($"Значения равны");
    }
    else
    {
        Console.WriteLine($"max ={left}");
    }
}
else
{
    Console.WriteLine("Введено не корректное значение ");
}