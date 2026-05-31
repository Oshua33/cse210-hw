using System;

class Program
{
    static void Main(string[] args)
    {

        //create 3-4 video
        Video video1 = new Video("How to make a cake", "Shua Elegance", 300);
        Video video2 = new Video("How to make a pizza", "Jane Doe", 600);
        Video video3 = new Video("How to make a salad", "John Andrew", 200);
        Video video4 = new Video("How to make a sandwich", "Jill Smith", 100);

        //create comment

        //add comment to video
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!")); 
        video2.AddComment(new Comment("Charlie", "I love this recipe!"));
        video2.AddComment(new Comment("Grace", "Great recipe!"));
        video3.AddComment(new Comment("Deb", "I love this recipe!"));
        video3.AddComment(new Comment("Dave", "Can't wait to try this!"));
        video4.AddComment(new Comment("Eve", "Thanks for the tutorial!"));
        video4.AddComment(new Comment("Joy", "Thanks for your time!"));
        video4.AddComment(new Comment("Eve", "This was so helpful!"));

        //save videos in a list
        List<Video> videos = new List<Video>();

        //add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        //loop through the each video and display them with the comments
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine("\nComments:");
            video.DisplayAllComments();
            Console.WriteLine("\n--***&&&----\n");
        }

        
    }

}