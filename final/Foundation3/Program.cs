using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
        Lecture lecture = new Lecture("Professor Jimmie Jones", "70", "Global Warming: Truth or Hoax?", "The effects of CO2 on our global climate", "4/20", "2:10 PM", "Lecture");
        Reception reception = new Reception("Respond back to make sure you are put on the list, or else....", "Lucas and Missy's wedding", "You are invited to Lucas' and Missy's wedding!", "9/13/2023", "3 PM", "Reception");
        Outdoor outdoorGathering = new Outdoor("Partly sunny, you never know..", "High adventure meeting", "Plan our high adventure! Make sure to invite your friends!", "7/19", "6 PM", "Outdoor Gathering");

        lecture.SetAddress("4959 Oakbank Ct", "Saint Cloud", "Florida", "USA");
        reception.SetAddress("292nd Ave SE", "Ravensqueen", "Washington", "USA");
        outdoorGathering.SetAddress("304 S 1nd W", "Rexburg", "Idaho", "USA");

        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoorGathering);

        Console.Clear();
        Console.WriteLine("------------------------------------\n");

        foreach(Event eventt in events)
        {
            Console.WriteLine(eventt.GetEventType());
            Console.WriteLine("\n----------------");
            Console.WriteLine("Short description:\n");
            Console.WriteLine(eventt.GetShortDesc());
            Console.WriteLine("----------------");
            Console.WriteLine("Standard details:\n");
            Console.WriteLine(eventt.GetStandardDesc());
            Console.WriteLine("----------------");
            Console.WriteLine("Full details:\n");
            Console.WriteLine(eventt.GetFullDesc());
            Console.WriteLine("------------------------------------\n");
        }
    }
}