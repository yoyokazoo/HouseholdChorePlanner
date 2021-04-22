using System;

[Serializable]
public class TaskDefinition
{
    public string Name { get; set; }
    public string Description { get; set; }

    public override string ToString()
    {
        return "Task Definition: " + Name + " " + Description;
    }
}