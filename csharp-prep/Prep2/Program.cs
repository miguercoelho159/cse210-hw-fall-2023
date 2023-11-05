using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string answer = Console.ReadLine();
        int grade_percentage = int.Parse(answer);

        string letter = "";
         
        if (grade_percentage >= 90)
        {
            letter = "A";
        }
        else if (grade_percentage >= 80)
        {
            letter = "B";
        }
        else if (grade_percentage >= 70)
        {
            letter = "C";
        }
        else if (grade_percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
         
        Console.WriteLine($"Your grade is: {letter}");


        if ( grade_percentage >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You didn't pass, better luck next time!");
        }


    }
}
