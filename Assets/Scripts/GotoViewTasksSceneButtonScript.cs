using UnityEngine;

public class GotoViewTasksSceneButtonScript : MonoBehaviour
{
    public void OnClicked()
    {
        SceneManagerScript.Instance.GotoScene(SceneManagerScript.VIEW_TASKS_SCENE);
    }
}
