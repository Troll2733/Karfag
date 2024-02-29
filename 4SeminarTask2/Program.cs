//Задайте массив заполненный случайными трехзначными числами , напишите программу которая покажет колличество четных чисел в масиве .
void main()
{
    int[] arraySize = new int[10];
    int[] array = GenereatArray(arraySize, 100, 1000);
    PrintArray(array);
    System.Console.WriteLine("\n Колличество четных чисел в массиве " + result(array));
}
int[] GenereatArray(int[] size, int left, int right)
{
    int[] array = new int[size.Length];
    for (int i = 0; i < size.Length; i++)
    {
        array[i] = new Random().Next(left, right);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}
int result(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
        {
            count++;
        }
    return count;
}
main();