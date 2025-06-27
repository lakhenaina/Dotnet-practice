// WAP to input a number and check Odd/Even.

using System;
class OddEven
{
public static void Main(string[] args)
{
Console.WriteLine("Enter a number");
int a= int.Parse(Console.ReadLine());
if (a % 2 ==0 )
Console.WriteLine("Even");
else
Console.WriteLine("Odd");
}
}