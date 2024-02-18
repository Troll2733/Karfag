// void main()
// {
//     int a = TextConsole("Введите число а: ");
//     int b = TextConsole("Введите число b: ");
//     int c = TextConsole("Введите число c: ");
//     int d = TextConsole("Введите число d: ");
//     int e = TextConsole("Введите число e: ");
//     int f = TextConsole("Введите число f: ");

//     System.Console.WriteLine($"{a} {b} {c} {d} {e} {f}");
// int a = 4;
// int b = 2;
// int c = 6;
// int d = 5;
// int e = 7;
// int f = 3;

//     int result(int)Math.Pow(a / b + a * a * a * b, 4);
//     int result2(int)Math.Pow(c / d + c * c * c * d, 4);
//     int result3(int)Math.Pow(e / f + e * e * e * f, 4);

// int result = sumTwoNumber(a, b);
// int result2 = sumTwoNumber(c, d);
// int result3 = sumTwoNumber(e, f);
// System.Console.WriteLine(result);
// System.Console.WriteLine(result2);
// System.Console.WriteLine(result3);

// }
// int TextConsole(string msg)
// {
//     System.Console.WriteLine(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }


// int sumTwoNumber(int firstNumber, int secondNumber)
// {
//     return (int)Math.Pow(firstNumber / secondNumber + firstNumber * firstNumber * firstNumber * secondNumber, 3);
// }

//main();



//Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,90]



int[] array = new int[10];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 101);
    System.Console.Write(array[i] + " ");
}

for (int i = 0; i < array.Length; i++)
    if (array[i] > 10 && array[i] < 90)
    {
        count = count + 1;
    }
System.Console.WriteLine($"\n Колличество эллементов = {count}");