using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Introduction to Product Awareness", "William Boateng", 300);
        video1.AddComment(new Comment("Kevin", "Great video! Very informative."));
        video1.AddComment(new Comment("Seth", "I liked the examples."));
        video1.AddComment(new Comment("Charles", "Can you do a follow-up on tracking metrics?"));
        videos.Add(video1);

        Video video2 = new Video("Advanced Tracking Techniques", "Jane Smith", 450);
        video2.AddComment(new Comment("David", "This helped me so much, thank you!"));
        video2.AddComment(new Comment("Eve", "Very clear explanations."));
        video2.AddComment(new Comment("Frank", "Can you share the source code?"));
        videos.Add(video2);

        Video video3 = new Video("Data Analysis Basics", "Mary Johnson", 400);
        video3.AddComment(new Comment("Grace", "Perfect for beginners."));
        video3.AddComment(new Comment("Hank", "Loved the visuals!"));
        video3.AddComment(new Comment("Ivy", "Would love to see more examples."));
        videos.Add(video3);

        Video video4 = new Video("Ethical Considerations in Product Awareness", "Tom Brown", 360);
        video4.AddComment(new Comment("Jack", "Wow! very educative."));
        video4.AddComment(new Comment("Karen", "Can you share more on data privacy?"));
        video4.AddComment(new Comment("Liam", "I think more real-world cases would help."));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}