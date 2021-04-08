using UnityEngine;
using TMPro;

public class ConfirmCreateTaskButtonScript : MonoBehaviour
{
    public TextMeshProUGUI NameInputText;
    public TextMeshProUGUI DescriptionInputText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClicked()
    {
        // create task definition
        TaskDefinition newTaskDefinition = new TaskDefinition();
        newTaskDefinition.Name = NameInputText.text;
        newTaskDefinition.Description = DescriptionInputText.text;

        // save task definition / serialize
        // if name is not unique, inform user
        TaskManagerScript.Instance.AddNewTaskDefinition(newTaskDefinition);

        // confirm creation/success/potentially go back to previous scene
        //Debug.Log("Saving task definition: " + newTaskDefinition);
    }
}
