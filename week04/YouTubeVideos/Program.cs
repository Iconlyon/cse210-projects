using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Introduction to C# Programming", "Daniel Abughdyer", 420);
        video1.AddComment(new Comment("Daniel", "This helped me understand the basics of C#."));
        video1.AddComment(new Comment("Mary", "The explanation was clear and easy to follow."));
        video1.AddComment(new Comment("Samuel", "Great video for beginners."));

        Video video2 = new Video("Understanding Classes and Objects", "Programming Basics", 600);
        video2.AddComment(new Comment("Grace", "Classes and objects make more sense now."));
        video2.AddComment(new Comment("Peter", "I liked the simple examples."));
        video2.AddComment(new Comment("Sarah", "This helped me with my assignment."));

        Video video3 = new Video("Abstraction in Object-Oriented Programming", "Computer Science Tutorials", 750);
        video3.AddComment(new Comment("Michael", "This was a useful explanation of abstraction."));
        video3.AddComment(new Comment("Joy", "I understand why abstraction is important now."));
        video3.AddComment(new Comment("David", "The examples made the concept easier to understand."));

        Video video4 = new Video("Encapsulation in C#", "Software Development", 540);
        video4.AddComment(new Comment("Blessing", "Encapsulation is much clearer to me now."));
        video4.AddComment(new Comment("James", "Good explanation of private variables and methods."));
        video4.AddComment(new Comment("Esther", "This was very helpful for learning OOP."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}