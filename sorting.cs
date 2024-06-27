using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Define a list of names
        List<string> names = new List<string>
        {
            "John",
            "Alice",
            "Bob",
            "Catherine",
            "David"
        };

        // Display the original list
        Console.WriteLine("Original list of names:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Sort the list of names in alphabetical order
        names.Sort();

        // Display the sorted list
        Console.WriteLine("\nSorted list of names:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
