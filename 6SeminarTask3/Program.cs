// Задайте произвольную строку. Выясните, является ли она палиндромом.

System.Console.WriteLine("Введите строку: ");
string? str = Console.ReadLine();
System.Console.WriteLine(str);

for (int i = 0; i < str!.Length / 2; i++)
{
    if (str[i] != str[str.Length - 1 - i])
    {
        System.Console.WriteLine("Не является палиндромом");
        return;
    }
    
    
}
System.Console.WriteLine("Является Палиндромом");


