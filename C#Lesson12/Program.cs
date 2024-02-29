using System.Drawing;

void main()
{
    int arraySize = readInt("Введите колличество элементов масива: ");
    int[] array = genereatArray(arraySize, 0, 1000);
    print(array);
    System.Console.WriteLine("\n" + countInt(array,1,7));

}
int readInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
void print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write(array[i] + " ");
}

int[] genereatArray(int size, int left, int right)
{
    int[] myArray = new int[size];
    Random rand= new Random();
    for (int i = 0; i < size; i++)
    {
        myArray[i] = rand.Next(left, right + 1);
    }
    return myArray;
}
int countInt(int[] size,int leftDigit,int rightDigit)
{
    int count = 0;

    for (int i = 0; i < size.Length; i++)
        if (size[i] % 10 == leftDigit && size[i] % rightDigit == 0)
            count++;
    return count;
}

main();



// Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа,сумма цифр которого чётная.


long count = 0;
while (true)
{
    System.Console.WriteLine("введите число или q для выхода");
    string? input = Console.ReadLine();
    if (input == "q")
    {
        System.Console.WriteLine("STOP");
        break;
    }

    long N = Convert.ToInt64(input);

    long sum = 0;

        while (N > 0)
        {
            count = N % 10;
            sum = count + sum;
            N = N / 10;
        }

    if (sum % 2 == 0)
    {
        System.Console.WriteLine($"Stop");
        break;
    }



}



