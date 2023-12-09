using System;

class Program
{
    static void Main(string[] args)
    {
        List<Excercise> activities = new List<Excercise>();
        Running running = new Running("Running", "9/15/23", 30, 3);
        Swimming swimming = new Swimming("Swimming", "11/27/23", 22, 11);
        Cycling cycling = new Cycling("Cycling", "12/01/23", 28, 20);


        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        Console.Clear();
        Console.WriteLine("--------------");
        foreach (Excercise excercise in activities)
        {
            Console.WriteLine(excercise.GetSummary());
            Console.WriteLine("--------------");
        }
    }
}