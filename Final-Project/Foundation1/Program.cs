using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Videos
        Video video1 = new Video("Nauvoo Pageant Week 1", "Kathryn Lambert", 1466);
        video1.AddComment("Avery Anderson", "Oh how fun! What a beautiful family.");
        video1.AddComment("Ally McCulloch", "This makes me want to be a part of the family cast next year. So cool!");

        Video video2 = new Video("The Hunger Games Musical: Mockingjay Parody - Peeta's Song", "Studio C", 184);
        video2.AddComment("Elley Marcus", "I love the “ what’s your favorite color” part. The face is just 100%");
        video2.AddComment("Bailey Midnight", "Hahahaha! 😂 Girls can't resist the boy with the 🍞! Team Peeta, here, all the way! Love you all at Studio C, thanks for keeping our family entertained with such fun, clean, humor! 💋");
        video2.AddComment("Alexa Harper", "Is no one going to talk about Whitney’s AMAZING high note at 2:15");

        Video video3 = new Video("Share the Light of Jesus Christ | #LightTheWorld", "The Church of Jesus Christ of Latter-Day Saints", 156);
        video3.AddComment("Ederson Cardo", "’m so grateful for everything my Savior does for us! Merry Christmas! ❤");
        video3.AddComment("Kim McKee","Beautiful. Thank you.");
        video3.AddComment("Katherine Reed", "So thankful for my Savior. 🌟");
        video3.AddComment("Marlee Craig", "Beautiful!! <3");

        Video video4 = new Video("Top 15 Skylines in North America | 2023", "City Geek", 522);
        video4.AddComment("Laura Bagley", "Great to see Minneapolis on this list, one of the best skylines in the country and VERY under appreciated.");
        video4.AddComment("Mark Rigby", "I've only been to about half the cities on your list. I also became interested in architecture when I lived in Seattle. That started in 1986.");
        video4.AddComment("John Walton", "As a huge fan of cities in population, skyline, things to do, and just drawing cities I love these videos and subbed to the channel!");
        video4.AddComment("Ruth Hamilton", "I  honestly can’t argue with any. NYC is massive but something about Chicago is more visually pleasing. Also Philly to me is often overlooked and I agree it’s 4. It’s a great skyline");

        // Create the list of videos
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Displaying information for each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Commenter}: {comment.CommentText}");

            }
            Console.WriteLine(); // Adding a line break between videos
            
        }
    }
}