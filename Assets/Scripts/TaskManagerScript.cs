using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public class TaskManagerScript : Singleton<TaskManagerScript>
{
    public List<TaskDefinition> tasks { get; private set; }

    public const string LOCAL_TASKS_FILE_PATH = "default_local_tasks.bin";

    void Awake()
    {
        Debug.Log("Task Manager Script loaded");
        tasks = LoadTasksFromLocal();
    }

    public void AddNewTaskDefinition(TaskDefinition newTask)
    {
        Debug.Log("Adding new task definition: " + newTask);

        tasks.Add(newTask);
        Debug.Log("Total Tasks: " + tasks.Count);
        SaveTasksToLocal();
    }

    public void ClearTasksFromLocal()
    {
        if(StorageHandler.DeleteData(LOCAL_TASKS_FILE_PATH))
        {
            Debug.Log("Deleted local tasks.");
        }
        else
        {
            Debug.Log("No local tasks to delete.");
        }
    }

    public void SaveTasksToLocal()
    {
        StorageHandler.SaveData(tasks, LOCAL_TASKS_FILE_PATH);
    }

    public List<TaskDefinition> LoadTasksFromLocal()
    {
        return StorageHandler.LoadOrCreateData<List<TaskDefinition>>(LOCAL_TASKS_FILE_PATH);
    }
}