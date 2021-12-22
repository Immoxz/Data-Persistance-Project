using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance; 

    private string playerName;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetPlayerName(string playerName)
    {
        this.playerName = playerName;
        Debug.Log("inside data manager "+ this.playerName);
    }


    public string  GetPlayerName()
    {
        return this.playerName;
    }


}
