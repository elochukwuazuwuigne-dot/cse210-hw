// GoalManager.cs


using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

  
    public void DisplayScore()
{
    Console.WriteLine($"\nYour Score: {_score}");

    if (_score >= 5000)
    {
        Console.WriteLine("Level 3 Disciple");
    }
    else if (_score >= 1000)
    {
        Console.WriteLine("Level 2 Adventurer");
    }
    else
    {
        Console.WriteLine("Level 1 Beginner");
    }
}

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void LoadGoals(string filename)
{
    string[] lines = File.ReadAllLines(filename);

    _goals.Clear();

    _score = int.Parse(lines[0]);

    Console.WriteLine("Goals loaded successfully.");
}

    public void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordGoal(int index)
    {
        int earned = _goals[index].RecordEvent();
        _score += earned;

        Console.WriteLine($"You earned {earned} points!");
    }

    // ADD THIS
    public void SaveGoals(string filename)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }
    }


}