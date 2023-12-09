using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Video> videos = new List<Video>();

        Video video1 = new Video("House tour!!", "Mclover", 1306);
        video1.AddComment("DiamondMiner74", "Nice house!!");
        video1.AddComment("PassiveThePassivePessimist", "Your house is kinda dumb.");
        video1.AddComment("ThatDude26", "I like your backyard man, looks cool!");
        videos.Add(video1);

        Video video2 = new Video("Horror game tuesday!", "EpicGamer123", 648);
        video2.AddComment("DiamondMiner74", "Scary!!");
        video2.AddComment("PassiveThePassivePessimist", "This game seems kinda boring, imho.");
        video2.AddComment("ThatDude26", "duuuude I gotta play this");
        video2.AddComment("scarygamewatcher", "jumpscare at 0:39!!!");
        video2.AddComment("FierotheGuy", "cmon man atleast put a jumpscare warning, lol");
        videos.Add(video2);

        Video video3 = new Video("Infected | dev log #37", "MarkTheProgrammer", 970);
        video3.AddComment("DiamondMiner74", "Awesome to see the progress!!");
        video3.AddComment("PassiveThePassivePessimist", "Progress has been way too slow, fasterrrr!!");
        video3.AddComment("ThatDude66", "nice bro cant wait to play this");
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetVideoInfo());
            video.DisplayCommentInfo();
        }
        Console.WriteLine("------------");
    }
}