using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# in 10 Minutes", "CodeSchool", 600);
        video1.AddComment(new Comment("Emmanuel", "Very helpful!"));
        video1.AddComment(new Comment("Smith", "Nice explanation."));
        video1.AddComment(new Comment("Adams", "This made sense."));
        videos.Add(video1);

        Video video2 = new Video("Best Study Tips", "StudentLife", 480);
        video2.AddComment(new Comment("Chris", "Needed this."));
        video2.AddComment(new Comment("John", "Great advice."));
        video2.AddComment(new Comment("Jordan", "Thanks for sharing."));
        videos.Add(video2);

        Video video3 = new Video("Morning Workout Routine", "FitDaily", 900);
        video3.AddComment(new Comment("Morgan", "Trying this tomorrow."));
        video3.AddComment(new Comment("Jane", "Love it!"));
        video3.AddComment(new Comment("Lucky", "Great energy."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.title}");
            Console.WriteLine($"Author: {video.author}");
            Console.WriteLine($"Length: {video.lengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.name}: {comment.text}");
            }

            Console.WriteLine();
        }
    }
}
