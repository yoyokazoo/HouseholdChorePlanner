using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskDefinitionScrollElementScript : MonoBehaviour
{
    public TextMeshProUGUI title;


    public void Initialize(TaskDefinition definition)
    {
        title.text = definition.Name;

        // use definition to look up instances from the schedule to populate the rest of the information
        
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
