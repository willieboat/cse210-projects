using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Show Score");
            Console.WriteLine("7. Exit");

            Console.Write("Select an option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    manager.CreateGoal();
                    break;
                case 2:
                    manager.DisplayGoals();
                    break;
                case 3:
                    Console.Write("Enter filename: ");
                    manager.SaveGoals(Console.ReadLine());
                    break;
                case 4:
                    Console.Write("Enter filename: ");
                    manager.LoadGoals(Console.ReadLine());
                    break;
                case 5:
                    manager.RecordEvent();
                    break;
                case 6:
                    manager.DisplayScore();
                    break;
                case 7:
                    return;
            }
            Console.WriteLine();
        }
    }
}
