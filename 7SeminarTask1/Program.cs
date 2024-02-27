// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

void main()
{
    int M = 9;
    int N = 3;
    Print(M,N);



}
void Print(int M,int N)
{
    if (M == N) return;
    Print(M - 1, N);
    System.Console.Write(M + " ");
}
main();