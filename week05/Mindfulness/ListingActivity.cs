using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : BaseActivity
{
    private static string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "What are things you're grateful for today?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many as you can in a certain area.")
    { }

    protected override void PerformActivity()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Length)];
        Console.WriteLine("\n" + prompt);
        Console.WriteLine("You have a few seconds to think...");
        ShowCountdown(5);

        Console.WriteLine("Start listing. Press Enter after each item:");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            if (!string.IsNullOrEmpty(Console.ReadLine()))
                count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
    }
}
