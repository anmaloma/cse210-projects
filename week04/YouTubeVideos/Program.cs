using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Learn C#", "Code Academy", 600);
        video1.AddComment(new Comment("Anthony", "Great video!"));
        video1.AddComment(new Comment("Carlos", "This was very helpful."));
        video1.AddComment(new Comment("Maria", "I learned a lot from this video."));

        Video video2 = new Video("Top 10 Places to Visit", "Travel World", 850);
        video2.AddComment(new Comment("John", "I want to visit these places!"));
        video2.AddComment(new Comment("Sofia", "Great recommendations."));
        video2.AddComment(new Comment("David", "Thanks for sharing!"));

        Video video3 = new Video("Easy Pasta Recipe", "Cooking Home", 420);
        video3.AddComment(new Comment("Daniel", "This looks delicious!"));
        video3.AddComment(new Comment("Laura", "I will try this recipe."));
        video3.AddComment(new Comment("Michael", "Very easy to follow."));

        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"- {comment._name}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}