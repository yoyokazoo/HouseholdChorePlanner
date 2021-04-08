using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TaskDefinitionScript : MonoBehaviour
{
    // make non-public once I figure out the loading flow
    public string Name;
    // public ??? Image;
    public string Description;

    public TextMeshProUGUI TaskNameText;
    public Image TaskImage;
    public TextMeshProUGUI TaskDescriptionText;

    // Start is called before the first frame update
    void Start()
    {
        TaskNameText.text = Name;
        TaskDescriptionText.text = Description;
    }
}
