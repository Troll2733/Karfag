System.Console.Write("Введите первое число: ");
int N1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int N2 = Convert.ToInt32(Console.ReadLine());

if (N1 == N2)
{
   System.Console.WriteLine(N1 + " = " + N2);
}

if (N1 > N2)
{
   int max = N1;
   int min = N2;

   System.Console.WriteLine("max = " + N1);
   System.Console.WriteLine("min = " + N2);
}
else
{
   int max = N2;
   int min = N1;

   System.Console.WriteLine("max = " + N2);
   System.Console.WriteLine("min = " + N1);
}
