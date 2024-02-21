using System.Runtime.ExceptionServices;

void main()
{
   int N1 = readInt("Введите первое число: ");
   int N2 = readInt("Введите второе число: ");
   RavnoZnak(N1, N2);
}
int readInt(string msg)
{
   System.Console.Write(msg);
   return Convert.ToInt32(Console.ReadLine());  
}
void RavnoZnak(int first, int second)
{
   if (first == second)
   {
      System.Console.WriteLine($"{first} = {second}");
   }
   else
   if (first > second)
   {
      System.Console.WriteLine($"max = {first} min = {second}");
   }
   else
   {
      System.Console.WriteLine($"min = {first} max = {second}");
   }

}
main();

