using System;

public class Course {

    private int id;
    private string name;
    private float weeklyDuration;

    public int Id
    {
        get => id;
        set => id = value > 0 ? value : throw new ArgumentException("ID must be positive");
    }
    public string Name
    {
        get => name;
        set => name = !string.IsNullOrWhiteSpace(value)
            ? value
            : throw new ArgumentException("Name cannot be empty");
    }
    public float WeeklyDuration
    {
        get => weeklyDuration;
        set => weeklyDuration = value >= 0
            ? value
            : throw new ArgumentException("Weekly duration cannot be negative");
    }
}
