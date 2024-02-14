// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
//выдаёт номер координатной четверти плоскости, в которой находится эта точка.


System.Console.WriteLine("введите 1 координату: ");
int numberX = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("введите 2 координату: ");
int numberY = Convert.ToInt32(Console.ReadLine());

if (numberX > 0 && numberY > 0)
{
    System.Console.WriteLine("Принадлжеит к первой четверти");
}
else
if (numberX > 0 && numberY < 0)
{
    Console.WriteLine("Принадлежит ко второй четверти");
}
else
if (numberX < 0 && numberY > 0)
{
    Console.WriteLine("Принадлежит к четвертой четверти");
}
else
if (numberX < 0 && numberY < 0)
{
    Console.WriteLine("Принадлежит ко третьей четверти");
}
else
{
System.Console.WriteLine("Не подходит под  условие");
}