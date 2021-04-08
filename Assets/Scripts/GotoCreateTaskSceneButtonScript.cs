using UnityEngine;

public class GotoCreateTaskSceneButtonScript : MonoBehaviour
{
    public void OnClicked()
    {
        SceneManagerScript.Instance.GotoScene(SceneManagerScript.CREATE_TASK_SCENE);
    }
}
