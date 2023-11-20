using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    private static GameManager _instance;
    public int mobsToKill { get; private set; }

    public static bool firstRun { get; set; }

    private GameManager()
    {
        firstRun = true;
        mobsToKill = 0;
    }

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameManager();
            }

            return _instance;
        }
    }

    public void addMob()
    {
        mobsToKill++;
    }

    public void removeMob()
    {
        mobsToKill--;
    }
}
