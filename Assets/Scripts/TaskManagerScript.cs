using System.Collections.Generic;
using UnityEngine;

// does this need to be a monobehavior?
public class TaskManagerScript : Singleton<TaskManagerScript>
{
    List<TaskDefinition> tasks;


    void Awake()
    {
        Debug.Log("Task Manager Script loaded");
        tasks = new List<TaskDefinition>();
    }

    public void AddNewTaskDefinition(TaskDefinition newTask)
    {
        Debug.Log("Adding new task definition: " + newTask);

        tasks.Add(newTask);
        Debug.Log("Total Tasks: " + tasks.Count);
    }
}