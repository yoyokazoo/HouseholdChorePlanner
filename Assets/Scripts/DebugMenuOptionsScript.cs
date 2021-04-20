using UnityEditor;
using UnityEngine;
public class DebugMenuOptionScript : MonoBehaviour
{
    // Add a menu item named "Do Something" to MyMenu in the menu bar.
    [MenuItem("Household Chore Planner Debug/Clear Tasks From Local")]
    static void ClearTasksFromLocal()
    {
        if (StorageHandler.DeleteData(TaskManagerScript.LOCAL_TASKS_FILE_PATH))
        {
            Debug.Log("Deleted local tasks.");
        }
        else
        {
            Debug.Log("No local tasks to delete.");
        }
    }
}