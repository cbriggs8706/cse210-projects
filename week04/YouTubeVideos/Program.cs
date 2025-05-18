using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video { Title = "How to Bake a Cake", Author = "Chef Madison", LengthInSeconds = 300 };
        video1.AddComment(new Comment("Regan", "This recipe was amazing!"));
        video1.AddComment(new Comment("Carter", "Can I use almond flour instead?"));
        video1.AddComment(new Comment("Roosevelt", "Loved it, thanks for sharing!"));
        videos.Add(video1);

        Video video2 = new Video { Title = "Top 10 Travel Destinations", Author = "Pierce", LengthInSeconds = 720 };
        video2.AddComment(new Comment("Hoover", "I want to go to all of these places."));
        video2.AddComment(new Comment("Coolidge", "Number 5 is definitely my favorite!"));
        video2.AddComment(new Comment("Harding", "Great list, added to my bucket list."));
        videos.Add(video2);

        Video video3 = new Video { Title = "Beginner's Guide to C#", Author = "Buchannan", LengthInSeconds = 450 };
        video3.AddComment(new Comment("McKinley", "Very helpful, thanks!"));
        video3.AddComment(new Comment("Cleveland", "Can you make one for Java too?"));
        video3.AddComment(new Comment("Grant", "Perfect intro to programming."));
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}
