using System;
using System.Reflection.Metadata.Ecma335;

class Program
{

    static void Main(string[] args)
    {
        DisplayMessage();
        
        string userName = UserName();
        int userNumber = FavNum();
        int squaredNumber = SquareNumber(userNumber);
       
        DisplayFinal(userName, squaredNumber);

        static void DisplayMessage()
            {
                Console.WriteLine("Hello world!");
            }
        static string UserName()
            {
                Console.WriteLine("What is your name? ");
                string name = Console.ReadLine();
                
                return name;
            }
        static int FavNum()
            {
                Console.WriteLine("What is your favorite number? ");
                int number = int.Parse(Console.ReadLine());
                
                return number;
            }
        static int SquareNumber(int number)
            {
                int square = (int)Math.Sqrt(number);
                
                return square;
            }
        static void DisplayFinal(string name, int square)
            {
                Console.WriteLine($"{name}, the square of your number is {square}.");
            }
        
    }
}