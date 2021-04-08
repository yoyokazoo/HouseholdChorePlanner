using UnityEngine;

public class GoButtonScript : MonoBehaviour
{
    public void OnClicked()
    {
        SceneManagerScript.Instance.GotoScene(SceneManagerScript.CURRENT_TASK_SCENE);
    }
}
