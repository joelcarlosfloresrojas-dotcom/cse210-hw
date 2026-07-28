using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video video1=new Video();
        Video video2=new Video();
        Video video3=new Video();
        Video video4=new Video();
      
        video1._title = "Easy 15-Minute Dinner Recipe";
        video1._author = "Cooking With Sarah";
        video1._length = 480; 


      
        video2._title = "Is the New Smartphone Worth It? Honest Review";
        video2._author = "Tech Unboxed";
        video2._length = 720; 


        
        video3._title = "10-Minute Morning Stretch Routine";
        video3._author = "Daily Fitness";
        video3._length = 600; 
       


        video4._title = "Weekend Trip: Exploring Downtown Chicago";
        video4._author = "Wanderlust Vlogs";
        video4._length = 1080; 

        Comment c1 = new Comment();
        c1._name = "Alex";
        c1._text = "Made this for dinner tonight and it was amazing!";
        video1._comments.Add(c1);

        Comment c2 = new Comment();
        c2._name = "Maria";
        c2._text = "Can I substitute garlic powder for real garlic?";
        video1._comments.Add(c2);

        Comment c3 = new Comment();
        c3._name = "John";
        c3._text = "Simple and fast, perfect for a busy weeknight.";
        video1._comments.Add(c3);

        // Comments for Video 2
        Comment c4 = new Comment();
        c4._name = "David";
        c4._text = "The camera comparison at 4:20 was super helpful.";
        video2._comments.Add(c4);

        Comment c5 = new Comment();
        c5._name = "Sarah";
        c5._text = "Still sticking with my current phone for another year.";
        video2._comments.Add(c5);

        Comment c6 = new Comment();
        c6._name = "Mike";
        c6._text = "Great review, thanks for keeping it short and to the point.";
        video2._comments.Add(c6);

        Comment c7 = new Comment();
        c7._name = "Emma";
        c7._text = "My lower back feels so much better after this.";
        video3._comments.Add(c7);

        Comment c8 = new Comment();
        c8._name = "Jake";
        c8._text = "Doing this every morning from now on!";
        video3._comments.Add(c8);

        Comment c9 = new Comment();
        c9._name = "Luke";
        c9._text = "Short, simple, and very effective.";
        video3._comments.Add(c9);

        Comment c10 = new Comment();
        c10._name = "Mia";
        c10._text = "The food spots look so good!";
        video4._comments.Add(c10);

        Comment c11 = new Comment();
        c11._name = "Chris";
        c11._text = "Adding these places to my travel bucket list.";
        video4._comments.Add(c11);

        Comment c12 = new Comment();
        c12._name = "Sam";
        c12._text = "Loved the editing and background music in this video.";
        video4._comments.Add(c12);

        
        List<Video> videosList = new List<Video> { video1, video2, video3, video4 };


        foreach (Video v in videosList)
        {
            v.DisplayVideo();
            Console.WriteLine("--------------------------------------\n");
        }
            }
}