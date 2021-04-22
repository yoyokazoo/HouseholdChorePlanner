using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskDefinitionScrollElementScript : MonoBehaviour
{
    public TextMeshProUGUI title;
    public TaskDefinition definition;


    public void Initialize(TaskDefinition _definition)
    {
        definition = _definition;
        title.text = definition.Name;

        // use definition to look up instances from the schedule to populate the rest of the information
        
    }

    public void OnDeleteClicked()
    {
        if (TaskManagerScript.Instance.DeleteTaskDefinition(definition))
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
