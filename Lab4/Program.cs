// See https://aka.ms/new-console-template for more information
class Program {
static void Main(String [] args){
Console.WriteLine(Calculator.Add(3,4));
Console.WriteLine(Calculator.Subtract(3,4));
}
}
public static class Calculator
{
public static int Add(int a, int b)
{
return b + a;
}
public static int Subtract(int a, int b)
{
return 0;
}
public static int Multiply(int a, int b)
{
return 0;
}
public static int Divide(int a, int b)
{
return 0;
}
}
