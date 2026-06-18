using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Learning C#", "Code Master", 600);

        video1.AddComment(new Comment("John", "Very helpful video!"));
        video1.AddComment(new Comment("Sarah", "I understand classes now."));
        video1.AddComment(new Comment("Mike", "Great explanation."));

        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Football Skills", "Ronaldo TV", 420);

        video2.AddComment(new Comment("Alex", "Amazing skills!"));
        video2.AddComment(new Comment("James", "CR7 is the GOAT."));
        video2.AddComment(new Comment("David", "Nice editing."));

        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Cooking Jollof Rice", "Chef Ada", 900);

        video3.AddComment(new Comment("Grace", "Looks delicious."));
        video3.AddComment(new Comment("Daniel", "Trying this tonight."));
        video3.AddComment(new Comment("Ella", "Best recipe ever!"));

        videos.Add(video3);

        // Display Videos
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comment List:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}