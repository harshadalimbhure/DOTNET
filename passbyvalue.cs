using System;

class Program
{
    static void Main()
    {
        int originalValue = 10;
        
        Console.WriteLine("Before calling ChangeValue method: " + originalValue);
        
        // Call the method and pass the value
        ChangeValue(originalValue);
        
        Console.WriteLine("After calling ChangeValue method: " + originalValue);
    }
    
    static void ChangeValue(int number)
    {
        // Change the value of the parameter
        number = 20;
        Console.WriteLine("Inside ChangeValue method: " + number);
    }
}
