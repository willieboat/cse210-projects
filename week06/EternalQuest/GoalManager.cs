class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record:");
        for (int i = 0; i < goals.Count; i++)
            Console.WriteLine($"{i + 1}. {goals[i].GetDetails()}");

        int index = int.Parse(Console.ReadLine()) - 1;
        score += goals[index].RecordEvent();
        Console.WriteLine("Event recorded!");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        foreach (var goal in goals)
            Console.WriteLine(goal.GetDetails());
    }

    public void DisplayScore() => Console.WriteLine($"Your score is: {score}");

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(score);
            foreach (var goal in goals)
                outputFile.WriteLine(goal.GetStringRepresentation());
        }
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename)) return;

        string[] lines = File.ReadAllLines(filename);
        score = int.Parse(lines[0]);
        goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string type = parts[0];
            string[] data = parts[1].Split(",");

            switch (type)
            {
                case "SimpleGoal":
                    goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3])));
                    break;
                case "EternalGoal":
                    goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                    break;
                case "ChecklistGoal":
                    goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[4]), int.Parse(data[3]), int.Parse(data[5])));
                    break;
            }
        }
        Console.WriteLine("Goals loaded.");
    }
}
