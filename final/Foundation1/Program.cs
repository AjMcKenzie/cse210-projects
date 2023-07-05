using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video video1 = new Video("AI Learns to WALK 3D", "Code Bullet", 1219);
        Comment video1Comment1 = new Comment("ClayDress", "Code Bullet really going for the 'Most Distractible YouTuber Award' with this one");
        Comment video1Comment2 = new Comment("electronicstsh3431", "I love how the 5 minute compilation of him messing around rather than fixing the bug is really relatable");
        Comment video1Comment3 = new Comment("mirro1270", "I really love the fact that CB sometimes does these videos that can be a great and chill way to learn about coding and then there are moments where he just sh**posts in unity for a whole video");
        Comment video1Comment4 = new Comment("kitsuneprincess4637", "I suddenly understand why it takes Evan so long to put out videos. I have to imagine every project goes through this type of fever dream. Absolutely beautiful.");
        video1.addComment(video1Comment1);
        video1.addComment(video1Comment2);
        video1.addComment(video1Comment3);
        video1.addComment(video1Comment4);

        Video video2 = new Video("I Abducted My Entire Neighborhood in The Sims 4", "Let's Game It Out", 1056);
        Comment video2Comment1 = new Comment("Neutral_Tired", "A horror story about an inexplicably ageless artist who kidnaps people and paints them every day basically documenting and selling their lives actually sounds interesting to read");
        Comment video2Comment2 = new Comment("chriscataldo3688", "The Rusty collection was the best joke I needed today.  Thank you for creating this and keeping it available for me to find today");
        Comment video2Comment3 = new Comment("maximusthedude8305", "The fact that he continues to paint pictures of his urn even after Rusty dies is absolutely chilling…");
        Comment video2Comment4 = new Comment("fernandolugo812", "This guy has the most chaotic evil energy I've ever witnessed.");
        video2.addComment(video2Comment1);
        video2.addComment(video2Comment2);
        video2.addComment(video2Comment3);
        video2.addComment(video2Comment4);


        Video video3 = new Video("400MPH Pool Break with a Cannon at 80,000FPS - The Slow Mo Guys", "The Slow Mo Guys", 982);
        Comment video3Comment1 = new Comment("crylune", "I absolutely love this channel. Why? Because it still is what it was a decade ago. Two guys filming themselves doing stuff in slow motion. Doesn't get more genuine than this.");
        Comment video3Comment2 = new Comment("Tyrogandio", "Truth be told, the outro with Dan doing his break looked really epic");
        Comment video3Comment3 = new Comment("crimsonseagull5898", "These 2 silly best friends geeking over slow motion and physics are a huge part of my childhood I love them!!!");
        Comment video3Comment4 = new Comment("derekyarno6644", "Lots of trick shots out there, and this is my all time favorite! Absolutely perfect shot! Smashing results, quite a nice break too!");
        video3.addComment(video3Comment1);
        video3.addComment(video3Comment2);
        video3.addComment(video3Comment3);
        video3.addComment(video3Comment4);

        Video video4 = new Video("Hitman VR is the GREATEST Game!", "LetsPlay", 1558);
        Comment video4Comment1 = new Comment("thena_geronimo8233", "For all my years watching these guys play, Gavin in Hitman will never fail to entertain me. It is simply endless joy watching this man");
        Comment video4Comment2 = new Comment("akbmfm", "I've watched Gavin grab the banana at least 20 times now and laugh consistently.");
        Comment video4Comment3 = new Comment("gzer0x", "I'm in tears. 'No one expects the 19 foot tall assassin.'");
        Comment video4Comment4 = new Comment("angelcastillo4333", "Love how gav used the fire extinguisher as a gun xD");
        video4.addComment(video4Comment1);
        video4.addComment(video4Comment2);
        video4.addComment(video4Comment3);
        video4.addComment(video4Comment4);
       

       videoList.Add(video1);
       videoList.Add(video2);
       videoList.Add(video3);
       videoList.Add(video4);
        
        foreach (Video video in videoList){
            video.Display();
        }
    }
}