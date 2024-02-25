// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Начальные условия:

// // Начальные условия
// int[,] numbers = new int[,] {
//     {1, 2, 3},
//     {1, 1, 0},
//     {7, 8, 2},
//     {9, 10, 11}
// };
// Выводится: 1
void main()
{
    int[,] matrix = GenereatMatrix(4, 3, 0, 15);
    PrintMatrix(matrix);
    System.Console.WriteLine();
    int[] array = MinSumElement(matrix);
    PrintArray(array);
    System.Console.WriteLine();
    System.Console.WriteLine(MinSum(array));


}

int MinSum(int[] array)
{
    int count=0;
    int min = 0;
    min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            count=i;
        }
    }
    return count;


}

int[,] GenereatMatrix(int line, int row, int left, int rigth)
{
    int[,] myMatrix = new int[line, row];
    Random rand = new Random();
    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < myMatrix.GetLength(1); j++)
        {
            myMatrix[i, j] = rand.Next(left, rigth + 1);
        }
    }
    return myMatrix;
}

void PrintMatrix(int[,] arrayMatrix)
{
    for (int i = 0; i < arrayMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < arrayMatrix.GetLength(1); j++)
        {
            System.Console.Write(arrayMatrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
void PrintArray(int[] array)
{


    System.Console.WriteLine("[" + string.Join(", ", array) + "]");

}

int[] MinSumElement(int[,] arrayMass)
{
    int[] myArray = new int[arrayMass.GetLength(0)];
    for (int i = 0; i < arrayMass.GetLength(0); i++)
    {
        int minSum = 0;
        for (int j = 0; j < arrayMass.GetLength(1); j++)
        {
            minSum += arrayMass[i, j];
        }
        myArray[i] = minSum;
    }
    return myArray;
}
main();