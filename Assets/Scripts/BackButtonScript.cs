using UnityEngine;

public class BackButtonScript : MonoBehaviour
{
    public void OnClicked()
    {
        SceneManagerScript.Instance.GotoPreviousScene();
    }
}
