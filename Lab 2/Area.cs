// WAP to input radius of circle and find its area.

using System;
class Area
{
public static void Main(string[] args)
{
Console.WriteLine("Enter the radius of circle");
double radius= Convert.ToDouble(Console.ReadLine());
double area= Math.PI*Math.Pow(radius, 2);
Console.WriteLine("The area of circle is: " +area);
}
}