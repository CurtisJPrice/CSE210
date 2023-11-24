internal class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration) { }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}, ");
            Thread.Sleep(1000); 
        }
    }

    public void Start()
    {
        ShowStartingMessage("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        int elapsedTime = 0;
        int breathDuration = 3; 

        while (elapsedTime < this.duration)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(breathDuration);
            Console.WriteLine();

            elapsedTime += breathDuration;

            Console.Write("Breathe out... ");
            ShowCountdown(breathDuration);
            Console.WriteLine();

            elapsedTime += breathDuration;
        }

        ShowEndingMessage("Breathing Activity", elapsedTime);
    }
}