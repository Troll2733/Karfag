// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

// Начальные условия:

// int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
// Выводится: 6

int[] array = new int[10];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    System.Console.Write(array[i] + " ");
}
for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0)
    {
        count = count + 1;
    }
System.Console.WriteLine($"\n колличество четных чисtk = {count}");