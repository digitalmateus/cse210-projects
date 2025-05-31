using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        var video1 = new Video("Creating a Program with C#", "Mateus Nunes", 900);
        var video2 = new Video("Building a Tree House", "Laura Viegas", 800);
        var video3 = new Video("Five steps for success", "John Connor", 800);
        var video4 = new Video("Back to the Future", "Dr Strange", 700);

        // comments
            video1.AddComment(new Comment("Alice", "Absolutely breathtaking!"));
            video1.AddComment(new Comment("Bob", "Makes me want to travel."));
            video1.AddComment(new Comment("Carla", "Great visuals and narration."));

            video2.AddComment(new Comment("Dave", "Tip #4 saved my project."));
            video2.AddComment(new Comment("Elena", "Super clear explanations!"));
            video2.AddComment(new Comment("Frank", "Can you make one for LINQ?"));

            video3.AddComment(new Comment("Grace", "Perfect way to start the day."));
            video3.AddComment(new Comment("Hannah", "I feel so relaxed now."));
            video3.AddComment(new Comment("Ian", "Short and effective."));

            video4.AddComment(new Comment("Jack", "Loved the storytelling."));
            video4.AddComment(new Comment("Kim", "Very informative."));
            video4.AddComment(new Comment("Leo", "Could you cover Greek history next?"));
            video4.AddComment(new Comment("Frank", "Can you make one for LINQ?"));

        var videos = new List<Video> { video1, video2, video3, video4 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments ({video.GetNumberComments()}):");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.GetName()}: {comment.GetComment()}");
            }
            Console.WriteLine("--------------------");
        }
    }
}
