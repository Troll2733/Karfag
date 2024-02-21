// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

// Начальные условия:

// int[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
// Выводится: 5.15

void main()
{
    double[] arraySize = new double[10];
    double[] array = GenereatArray(arraySize.Length, 0, 10);
    printArray(array);
    double max = MaxIliment(array, array[0]);
    double min = MinIliment(array, array[0]);
    System.Console.WriteLine();
    System.Console.WriteLine($" разница максимального и минимального значения {max - min}");
}
double[] GenereatArray(int size, int left, int right)
{
    double[] myArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = Math.Round(new Random().NextDouble() + new Random().Next(left, right + 1),3);
    }
    return myArray;
}
void printArray(double[] mySize)
{
    for (int i = 0; i < mySize.Length; i++)
    {
        System.Console.Write(mySize[i] + "\t");
    }
}
double MaxIliment(double[] size, double max)
{
    for (int i = 0; i < size.Length; i++)
        if (max < size[i])
            max = size[i];

    return max;
}
double MinIliment(double[] size, double min)
{
    for (int i = 0; i < size.Length; i++)
        if (min > size[i])
            min = size[i];
    return min;
}

main();