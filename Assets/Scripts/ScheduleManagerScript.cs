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

    public void ScheduleFromScratch()
    {
        // iterate through task definitions, schedule all daily tasks
        // then all every X days tasks, so that we get the weird ones out of the way and the loads get set approx correctly
        // then weekly tasks, splitting across days of week
        // then monthly tasks, plopping them on days with low load.  Only schedule first 28 days of a given month so we don't have to care about different month lengths
    }
}