using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        // List to store instances of Video with their comments
        List<Video> videoList = new List<Video>();
        
        // Introduction
        Console.WriteLine("Welcome to the Video and comment tracker! ");
        Console.WriteLine();
        
        // First Video Method #1:  Getting information for first video instance (Having user input the video info)
        // Console.WriteLine("What is the title of the video? ");
        // string title = Console.ReadLine();
        // Console.WriteLine("Who is the author of the video? ");
        // string author = Console.ReadLine();
        // Console.WriteLine("How long is the video? (Seconds) ");
        // int length = int.Parse(Console.ReadLine());

        // First Video Method #2: Hard code in video info
        string title = "Coolest roller coast in America";
        string author = "Roller Coaster Man";
        int length = 100;

        // Creating first video instance
        Video video1 = new Video(title, author, length);

        // First Comment Method #1: Getting info for first comment on video1 (Having user input the comment)
        // Console.WriteLine("What is the name of the commenter? ");
        // string commenterName = Console.ReadLine();
        // Console.WriteLine("What did the comment say? ");
        // string commentText = Console.ReadLine();

        // First Comment1 Method #2: Hard code in comments
        string commenterName1 = "Emily";
        string commentText1 = "Your video is the best! ";

        string commenterName2 = "Potatobro208";
        string commentText2 = "I've had more fun watching a potato grow. ";
        
        string commenterName3 = "Lebron James";
        string commentText3 = "Come check out the roller coasters we have in LA! ";

        // Creating comment instances on video1
        Comment comment1 = new Comment(commenterName1, commentText1);
        Comment comment2 = new Comment(commenterName2, commentText2);
        Comment comment3 = new Comment(commenterName3, commentText3);
        
        // Adding comment instances to video1's comment list
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        // Adding video1 instances with its comments to sotre in the videoList
        videoList.Add(video1);

        // VIDEO #2 instance
        title = "Happy Wife Happy Life";
        author = "Happy Couple Vlogs";
        length = 200;

        Video video2 = new Video(title, author, length);

        commenterName1 = "Jason Bourne";
        commentText1 = "Ain't that the truth! ";

        commenterName2 = "Michael Jordan";
        commentText2 = "Good man! ";
        
        commenterName3 = "Grumpyman503";
        commentText3 = "You look too young to be married! This is probably fake! ";

        string commenterName4 = "Dallin H. Oaks";
        string commentText4 = "Such a happy wonderful family! ";

        comment1 = new Comment(commenterName1, commentText1);
        comment2 = new Comment(commenterName2, commentText2);
        comment3 = new Comment(commenterName3, commentText3);
        Comment comment4 = new Comment(commenterName4, commentText4);

        video2.AddComment(comment1);
        video2.AddComment(comment2);
        video2.AddComment(comment3);
        video2.AddComment(comment4);

        videoList.Add(video2);

        // VIDEO #3 isntance
        title = "Best NBA Highlights in November 2025";
        author = "NBA";
        length = 500;

        Video video3 = new Video(title, author, length);

        commenterName1 = "John Doe";
        commentText1 = "The NBA is so soft! ";

        commenterName2 = "Tom Brady";
        commentText2 = "Retirement is goooooood! ";
        
        commenterName3 = "Adam Silver";
        commentText3 = "Amazing Highlights, tune in to December's Christmas matchups! ";

        comment1 = new Comment(commenterName1, commentText1);
        comment2 = new Comment(commenterName2, commentText2);
        comment3 = new Comment(commenterName3, commentText3);

        video3.AddComment(comment1);
        video3.AddComment(comment2);
        video3.AddComment(comment3);

        videoList.Add(video3);
        
        // Interate and display each video with their comments
        int videoNumber = 0;
        foreach (Video v in videoList)
        {
            videoNumber++;

            Console.WriteLine($"Video {videoNumber}");
            v.DisplayVideoInfo();
            v.DisplayComments();
        }
    }
}

