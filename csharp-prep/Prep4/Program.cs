using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int inputNumber = -1; 
    
        while (inputNumber != 0)
        { 
            Console.WriteLine("Enter a number (0 to exit): ");
            
            string userResponse = Console.ReadLine();
            inputNumber = int.Parse(userResponse);
            
            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
        
        }

        int total = numbers.Sum();
        Console.WriteLine($"The sum is: {total}");

        int average = (int)numbers.Average();
        Console.WriteLine($"The average is: {average}");
    
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");


    
    
    
    
    
    
    
    
    
    
    
    }
}