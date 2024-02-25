// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Начальные условия:
// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// }; 
// Выводится:
// 9   10  11  12
// 5   6   7   8
// 1   2   3   4
using System.Numerics;

void main()
{
    int[,] matrix = new int[3, 4];
    int[,] newMatrix = genereatMatrix(3, 4, 0, 10);
    PrintMatrix(newMatrix);
    System.Console.WriteLine();
    int[,] array = reverseMass(newMatrix);
    PrintMatrix(array);
}

int[,] genereatMatrix(int line, int row, int left, int rigth)
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
void PrintMatrix(int[,] myMatrix)
{
    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < myMatrix.GetLength(1); j++)
        {
            System.Console.Write(myMatrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }

}
int[,] reverseMass(int[,] myMatrix)
{
    int temp =0;
    for (int i = 0; i < myMatrix.GetLength(0)/2; i++)
    {
        for (int j = 0; j < myMatrix.GetLength(1); j++)
        {
            temp = myMatrix[i,j];
            myMatrix[i,j] = myMatrix[myMatrix.GetLength(0)-1,j];
            myMatrix[myMatrix.GetLength(0)-1,j] = temp;
        }
        
    }
    return myMatrix;
}


main();