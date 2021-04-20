using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScheduleManagerScript : Singleton<SceneManagerScript>
{
    


    void Awake()
    {
        Debug.Log("Schedule Manager Script loaded");
    }

    public void GotoScene(string scene, Boolean resetStack = false)
    {

    }

    public void GotoPreviousScene()
    {

    }
}