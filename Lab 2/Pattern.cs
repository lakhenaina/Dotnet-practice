// WAP to print the series
// *
// **
// ***
// ****
// *****

using System;
class Pattern
{
public static void Main(string[] args)
{
for(int i=0;i<=5;i++)
{
for(int j=1;j<=i;j++)
{
Console.Write("*");
}
Console.WriteLine();
}
}
}