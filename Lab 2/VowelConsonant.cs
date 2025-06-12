// WAP to input a letter and check vowel/consonant.

using System;
class VowelConsonant
{
public static void Main(String[] args)
{
Console.WriteLine("Enter a character");
char ch=Console.ReadLine()[0];
if (ch=='a'||ch=='e'||ch=='i'||ch=='o'||ch=='u')
{
Console.WriteLine("Vowel");
}
else{
Console.WriteLine("Consonant");
}
}
}