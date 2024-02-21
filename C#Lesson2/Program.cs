void main()
{
    int number1 = readInt("Введите первое число: ");
    int number2 = readInt("Введите второе число: ");
    int number3 = readInt("Введите третье число: ");

    int max = number1;

    if (max < number2)
    {
        max = number2;
    }
    if (max < number3)
    {
        max = number3;
        System.Console.WriteLine($"max = {max}");
    }
    else
    {
        System.Console.WriteLine($"max = {max}");
    }
}
int readInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

main();