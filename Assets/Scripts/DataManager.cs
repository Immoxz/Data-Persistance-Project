using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    PlayerData player = new PlayerData();
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
        this.player.playerName = playerName;
        //Debug.Log("inside data manager "+ this.playerName);
    }


    public string GetPlayerName()
    {
        return this.player.playerName;
    }

    public int GetPlayerTopScore()
    {
        // to do
        return this.player.score;
    }
    public void SetPlayerTopScore(int score)
    {

        if (this.player.score < score)
            this.player.score = score;
    }

    [Serializable]
    public class PlayerData
    {
        public int score;
        public string playerName;
        public PlayerData()
        {
            this.score = 0;
            this.playerName = "";
        }
    }

    public void SavePlayer()
    {
        string jsonToSave = JsonUtility.ToJson(this.player);
        Debug.Log(jsonToSave);
        string file_path = Application.persistentDataPath + "/savePlayer" + this.player.playerName + ".json";
        File.WriteAllText(file_path, jsonToSave);

    }

    public void LoadPlayer()
    {
        string file_path = Application.persistentDataPath + "/savePlayer" + this.player.playerName + ".json";
        if (File.Exists(file_path))
        {
            string playerDataJson = File.ReadAllText(file_path);
            Debug.Log(playerDataJson);
            this.player = JsonUtility.FromJson<PlayerData>(playerDataJson);
        }

    }
}
