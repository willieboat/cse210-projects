using System;
using System.Threading;

public class BreathingActivity : BaseActivity
{
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    protected override void PerformActivity()
    {
        int interval = 4;
        int cycleCount = _duration / (interval * 2);

        for (int i = 0; i < cycleCount; i++)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(interval);
            Console.Write("Breathe out... ");
            ShowCountdown(interval);
        }
    }
}
