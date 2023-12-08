using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Lecture Events
        Lecture lectureEvent1 = new Lecture
        {
            Title = "Tech Talk",
            Description = "Exploring new technologies",
            Date = new DateTime(2023, 12, 12, 5, 30, 00),
            Time = new TimeSpan(7, 0, 0),
            Address = new Address { Street = "123 Main St", City = "Anoka", State = "MN", ZipCode = "55303" },
            Speaker = "Phil Rice",
            Capacity = 50
        };
        Lecture lectureEvent2 = new Lecture
        {
            Title = "CSE Department Forum",
            Description = "Career and Spiritual Growth in Game Development",
            Date = new DateTime(2023, 12, 7, 11, 30, 00),
            Time = new TimeSpan(2, 0, 0),
            Address = new Address { Street = "525 S Center St", City = "Rexburg", State = "ID", ZipCode = "83440" },
            Speaker = "Ryan Anderson",
            Capacity = 120
        };
        // Create Reception Events
        Reception receptionEvent1 = new Reception
        {
            Title = "Wedding Reception",
            Description = "Sadie and Johnny's Wedding Reception",
            Date = new DateTime(2024, 01, 31, 10, 00, 00),
            Time = new TimeSpan(1, 0, 0),
            Address = new Address { Street = "750 S 2nd E", City = "Rexburg", State = "ID", ZipCode = "83440" },
            RsvpEmail = "sadievoe22@gmail.com"
        };
        Reception receptionEvent2 = new Reception
        {
            Title = "Emma's Mission Farewell",
            Description = "Farewell reception for Emma Lampert",
            Date = new DateTime(2023, 12, 31, 09, 00, 00),
            Time = new TimeSpan(3, 0, 0),
            Address = new Address { Street = "2742 Yellowstone Blvd", City = "Anoka", State = "MN", ZipCode = "55303" },
            RsvpEmail = "emma.lampert@gmail.com"
        };
        // Create Outdoor Gathering Events
        OutdoorGathering outdoorEvent1 = new OutdoorGathering
        {
            Title = "Ward Memorial Day Picnic",
            Description = "Anoka Ward Annual Memorial Day picnic",
            Date = new DateTime(2024, 05, 27, 11, 00, 00),
            Time = new TimeSpan(5, 0, 0),
            Address = new Address { Street = "2400 Forest Ave", City = "Anoka", State = "MN", ZipCode = "55303" },
            WeatherForecast = "Sunny with a chance of clouds"
        };
        OutdoorGathering outdoorEvent2 = new OutdoorGathering
        {
            Title = "Taylor Swift: The Eras Tour Outdoor Movie Night",
            Description = "Movie night for the release of Taylor Swift: The Eras Tour",
            Date = new DateTime(2023, 12, 13, 06, 00, 00),
            Time = new TimeSpan(4, 0, 0),
            Address = new Address { Street = "S 2nd W & 3rd W", City = "Rexburg", State = "ID", ZipCode = "83440" },
            WeatherForecast = "Cold with a chance of snow"
        };
        // Generate marketing messages for each event
        Console.WriteLine("Lecture Event:");
        Console.WriteLine("***********************");
        Console.WriteLine("*** Standard Details ***");
        Console.WriteLine(lectureEvent1.GetStandardDetails());
        Console.WriteLine("\n*** Full Details ***");
        Console.WriteLine(lectureEvent1.GetFullDetails());
        Console.WriteLine("\n*** Short Description ***");
        Console.WriteLine(lectureEvent1.GetShortDescription());
        Console.WriteLine("***********************");
        Console.WriteLine();

        Console.WriteLine("Lecture Event:");
        Console.WriteLine("***********************");
        Console.WriteLine("*** Standard Details ***");
        Console.WriteLine(lectureEvent2.GetStandardDetails());
        Console.WriteLine("\n*** Full Details ***");
        Console.WriteLine(lectureEvent2.GetFullDetails());
        Console.WriteLine("\n*** Short Description ***");
        Console.WriteLine(lectureEvent2.GetShortDescription());
        Console.WriteLine("***********************");
        Console.WriteLine();

        Console.WriteLine("Reception Event:");
        Console.WriteLine("***********************");
        Console.WriteLine("*** Standard Details ***");
        Console.WriteLine(receptionEvent1.GetStandardDetails());
        Console.WriteLine("\n*** Full Details ***");
        Console.WriteLine(receptionEvent1.GetFullDetails());
        Console.WriteLine("\n*** Short Description ***");
        Console.WriteLine(receptionEvent1.GetShortDescription());
        Console.WriteLine("***********************");
        Console.WriteLine();

        Console.WriteLine("Reception Event:");
        Console.WriteLine("***********************");
        Console.WriteLine("*** Standard Details ***");
        Console.WriteLine(receptionEvent2.GetStandardDetails());
        Console.WriteLine("\n*** Full Details ***");
        Console.WriteLine(receptionEvent2.GetFullDetails());
        Console.WriteLine("\n*** Short Description ***");
        Console.WriteLine(receptionEvent2.GetShortDescription());
        Console.WriteLine("***********************");
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Event:");
        Console.WriteLine("***********************");
        Console.WriteLine("*** Standard Details ***");
        Console.WriteLine(outdoorEvent1.GetStandardDetails());
        Console.WriteLine("\n*** Full Details ***");
        Console.WriteLine(outdoorEvent1.GetFullDetails());
        Console.WriteLine("\n*** Short Description ***");
        Console.WriteLine(outdoorEvent1.GetShortDescription());
        Console.WriteLine("***********************");
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Event:");
        Console.WriteLine("***********************");
        Console.WriteLine("*** Standard Details ***");
        Console.WriteLine(outdoorEvent2.GetStandardDetails());
        Console.WriteLine("\n*** Full Details ***");
        Console.WriteLine(outdoorEvent2.GetFullDetails());
        Console.WriteLine("\n*** Short Description ***");
        Console.WriteLine(outdoorEvent2.GetShortDescription());
        Console.WriteLine("***********************");
        Console.WriteLine();
    
    }
}