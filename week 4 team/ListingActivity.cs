internal class ListingActivity : Activity
{
    private string[] listPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private string[] additionalQuestions = {
        "What are your favorite hobbies?",
        "Think about a recent accomplishment and describe how it made you feel.",
        "Reflect on a challenge you've overcome and what you learned from it.",
        "Consider a goal you have for the future and what steps you can take to achieve it."
    };

    public ListingActivity(int duration) : base(duration) { }

    private void ShowAdditionalQuestion(int countdownDuration)
    {
        Console.WriteLine($"\nNext question in {countdownDuration} seconds:");

        for (int i = countdownDuration; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }

        Console.WriteLine();
        Console.WriteLine(additionalQuestions[new Random().Next(additionalQuestions.Length)]);
    }

    public void Start()
    {
        ShowStartingMessage("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        int elapsedTime = 0;
        Random random = new Random();

        while (elapsedTime < this.duration)
        {
            string prompt = listPrompts[random.Next(listPrompts.Length)];
            Console.WriteLine(prompt);

            int countdownDuration = Math.Min(10, this.duration - elapsedTime);
            if (countdownDuration > 0)
            {
                ShowAdditionalQuestion(countdownDuration);
                elapsedTime += countdownDuration;
            }

            ShowSpinner(1);
            elapsedTime += 1;
        }

        Console.WriteLine($"\nNumber of items entered: {elapsedTime}");
        ShowEndingMessage("Listing Activity", elapsedTime);
    }
}