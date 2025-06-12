using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> countries = new List<string> { "Nepal", "India", "Norway", "Brazil", "Nigeria" };
        var result = countries.Where(c => c.StartsWith("N"));
        Console.WriteLine("Countries starting with 'N':");
        foreach (var c in result)
            Console.WriteLine(c);
    }
}
