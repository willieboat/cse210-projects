using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle = "Aviation Profiler";
        job1._company = "APSS";
        job1._startYear = 2017;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Security Officer";
        job2._company = "ACJCOLDS";
        job2._startYear = 2022;
        job2._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "William Ntow Boateng";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}