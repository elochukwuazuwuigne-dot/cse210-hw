// Program section
// Creativity:
// Added a leveling system that rewards users with titles
// as they gain points throughout their Eternal Quest.

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();

        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("\nEternal Quest");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");

            choice = int.Parse(Console.ReadLine());

            switch(choice)
            {

                // Create goal
                case 1:

                Console.WriteLine("Select Goal Type:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");

                int goalType = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (goalType == 1)
                {
                    manager.AddGoal(
                        new SimpleGoal(name, description, points));
                }
                else if (goalType == 2)
                {
                    manager.AddGoal(
                        new EternalGoal(name, description, points));
                }
                else if (goalType == 3)
                {
                    Console.Write("Target Count: ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Bonus Points: ");
                    int bonus = int.Parse(Console.ReadLine());

                    manager.AddGoal(
                        new ChecklistGoal(
                            name,
                            description,
                            points,
                            target,
                            bonus));
                }

                break;


                case 2:
                manager.ListGoals();
                break;

                case 3:
                manager.ListGoals();

                Console.Write("Select Goal: ");
                int goal = int.Parse(Console.ReadLine());

                manager.RecordGoal(goal - 1);
                break;


                case 4:

                Console.Write("Filename: ");
                string saveFile = Console.ReadLine();

                manager.SaveGoals(saveFile);

                break;

                 case 5:

                Console.Write("Filename: ");
                string loadFile = Console.ReadLine();

                manager.LoadGoals(loadFile);

                break;



        }
     }  }