using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Achievement
{
    public string name; 
    public string Description;
    public bool isUnlocked;
    public int currentProgress;
    public int goal;

    public Achievement(string name, string description, int goal)
    {
        this.name = name;
        this.Description = description;
        this.isUnlocked = false;
        this.currentProgress = 0;
        this.goal = goal;
    }

    public void AddProgress(int amount)
    {
        if(!isUnlocked)
        {
            currentProgress += amount;
            if(currentProgress >= goal)
            {
                isUnlocked = true;
                OnAchivementUnlocked();
            }
        }
    }

    protected virtual void OnAchivementUnlocked()
    {
        Debug.Log($"���� �޼� : {name}");
    }
}
