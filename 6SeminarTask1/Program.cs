// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char[,] a =
{
{'a','e','c'},
{'-','<','}'},
{'h','e','c'}
};
string str = "";
for (int i = 0; i < a.GetLength(0); i++)
    for (int j = 0; j < a.GetLength(1); j++)
    {
        str += a[i,j];

    }
    System.Console.WriteLine(str);







