public class Lecture : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Lecture\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
    }
}