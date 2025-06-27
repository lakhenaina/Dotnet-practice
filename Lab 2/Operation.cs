// 1. WAP to input two numbers and perform addition, subtraction, multiplication and division.
using System;
class Operation
{
public static void Main(string[] args)
{
Console.WriteLine("Enter two numbers");
int a= int.Parse(Console.ReadLine());
int b= int.Parse(Console.ReadLine());
int c= a+b;
int d= a-b;
int e= a*b;
int f= a/b;
Console.WriteLine("Addition : " +c);
Console.WriteLine("Subtraction : " +d);
Console.WriteLine("Multiplication : " +e);
Console.WriteLine("Division : " +f);
}
}


