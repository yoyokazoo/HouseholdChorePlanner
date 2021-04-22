using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewTasksScrollableScript : MonoBehaviour
{
    public GameObject contentLayoutGroup;

    public GameObject dailyTasksContainer;
    public GameObject weeklyTasksContainer;
    public GameObject monthlyTasksContainer;

    public GameObject taskDefinitionPrefab;
    public GameObject noTasksPrefab;

    public GameObject exampleTaskDefinition;
    public GameObject exampleNoTasks;


    // Start is called before the first frame update
    void Start()
    {
        GameObject.Destroy(exampleTaskDefinition);
        GameObject.Destroy(exampleNoTasks);

        foreach (TaskDefinition definition in TaskManagerScript.Instance.tasks)
        {
            AddTaskDefinitionElement(dailyTasksContainer, definition);
        }

        //AddNoTasksElement(dailyTasksContainer);
        AddNoTasksElement(weeklyTasksContainer);
        AddNoTasksElement(monthlyTasksContainer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddTaskDefinitionElement(GameObject location, TaskDefinition definition)
    {
        GameObject taskDefinitionScrollElement = Instantiate(taskDefinitionPrefab);
        TaskDefinitionScrollElementScript taskDefinitionScrollElementScript = taskDefinitionScrollElement.GetComponent<TaskDefinitionScrollElementScript>();
        taskDefinitionScrollElementScript.Initialize(definition);

        taskDefinitionScrollElement.transform.SetParent(contentLayoutGroup.transform);
        taskDefinitionScrollElement.transform.SetSiblingIndex(location.transform.GetSiblingIndex() + 1);
    }

    void AddNoTasksElement(GameObject location)
    {
        GameObject noTasks = Instantiate(noTasksPrefab);
        noTasks.transform.SetParent(contentLayoutGroup.transform);
        noTasks.transform.SetSiblingIndex(location.transform.GetSiblingIndex() + 1);
    }
}
