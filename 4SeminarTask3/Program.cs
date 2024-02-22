// Напишите программу которая перевернет одномерный массив (первый элемент станет последним , второй предпоследним итд...)

// using System.Runtime.InteropServices;

void main()
{
    int[] array = new int[10];
    int[] myArray = genereatArray(array.Length, 100, 1000);
    PrintArray(myArray);
    System.Console.WriteLine();
    int[] ReversArray = Result(myArray);
    PrintArray(ReversArray);


}

int[] genereatArray(int arraySize, int left, int right)
{
    int[] myArray = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        myArray[i] = new Random().Next(left, right);
    }
    return myArray;
}
void PrintArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        System.Console.Write(myArray[i] + " ");
    }
}
int[] Result(int[] Array)
{
    int temp = 0;
    for (int i = 0; i < Array.Length/2; i++)
    {
        temp = Array[i];
        Array[i] = Array[Array.Length-1-i];
        Array[Array.Length-1-i] = temp;
    }
    return Array;
}
main();




