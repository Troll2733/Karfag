// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет: "Позиция по рядам выходит за пределы массива"
// или "Позиция по колонкам выходит за пределы массива"


void main()
{
    int[,] matrix = GenereatMatrix(3, 4, 0, 10);
    PrintMatrix(matrix);
    int X = ReadIntX("Введите координату масива x: ");
    int Y = ReadIntY("Введите координату масива y: ");
    if(Element(matrix,X,Y)==false)
    {
        System.Console.WriteLine("Вышли за рамки массива");
    }
    else
    if(Element(matrix,X,Y)==true)
    {
        System.Console.WriteLine("Число массива " + " " + matrix[X,Y]);
    }
    
}

bool Element(int[,] matrix, int X, int Y)
{
    bool tot = true;
    if (X >= matrix.GetLength(0) || Y >= matrix.GetLength(1))
    {
        tot = false;
    }
    return tot;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
int ReadIntX(string msg)
{
    System.Console.WriteLine(msg);
    int line = Convert.ToInt32(Console.ReadLine());
    return line;
}
int ReadIntY(string msg)
{
    System.Console.WriteLine(msg);
    int row = Convert.ToInt32(Console.ReadLine());
    return row;
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
main();