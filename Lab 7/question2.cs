using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> countries = new List<string> { "Nepal", "India", "Norway", "Brazil", "Egypt" };
        var result = countries.Where(c => c.Contains('a') || c.Contains('i'));
        Console.WriteLine("Countries containing 'a' or 'i':");
        foreach (var c in result)
            Console.WriteLine(c);
    }
}
