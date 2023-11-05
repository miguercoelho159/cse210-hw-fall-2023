using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1,101);

        int guess = 1;

        while (guess != magic_number)
        {        

            Console.WriteLine("What is your guess? ");
            string string_guess = Console.ReadLine();
            guess = int.Parse(string_guess);

            if (guess > magic_number)
            {
                Console.WriteLine("Lower!");
            }

            else if (guess < magic_number)
            {
                Console.WriteLine("Higher!");
            }

            else 
            {
                Console.WriteLine("You got it!");
            }
        }
        



    }
}