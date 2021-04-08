using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// does this need to be a monobehavior?
public class SceneManagerScript : Singleton<SceneManagerScript>
{
    public const string HOME_SCENE = "HomeScene";
    public const string CURRENT_TASK_SCENE = "CurrentTaskScene";
    public const string CREATE_TASK_SCENE = "CreateTaskScene";

    Stack<string> scenes;


    void Awake()
    {
        Debug.Log("Scene Manager Script loaded");
        scenes = new Stack<string>();
    }

    public void GotoScene(string scene, Boolean resetStack = false)
    {
        if (resetStack)
        {
            scenes.Clear();
        }
        else
        {
            scenes.Push(scene);
        }

        SceneManager.LoadScene(scene);
    }

    public void GotoPreviousScene()
    {
        scenes.Pop();
        string previousScene = scenes.Count > 0 ? scenes.Peek() : HOME_SCENE;

        SceneManager.LoadScene(previousScene);

        // theoretically on android we call this method if the back button is pressed, so if we're already on the home scene, minimize the app if that's the case
    }
}