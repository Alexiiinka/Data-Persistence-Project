using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;
    public Text playerNameInput;
    public Player newPlayer = new Player();
    
    public static int BestScore = 0;
    public static string BestScoreName = "";

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadDataFunction();
    }

    public class Player
    {
        public string playerName;
        public int playerScore = 0;
    }

    [System.Serializable]
    public class SaveData
    {
        public string bestPlayerName;
        public int bestPlayerScore;
    }

    public void DataSaveFunkcion()
    {
        SaveData bestPlayer = new SaveData();
        bestPlayer.bestPlayerName = BestScoreName;
        bestPlayer.bestPlayerScore = BestScore;
        string json = JsonUtility.ToJson(bestPlayer);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadDataFunction()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData bestPlayer = JsonUtility.FromJson<SaveData>(json);
            BestScoreName = bestPlayer.bestPlayerName;
            BestScore = bestPlayer.bestPlayerScore;
        }
        
    }

    public void playerNameChanged(string name)
    {
        newPlayer.playerName = playerNameInput.text;
        Debug.Log(newPlayer.playerName);
    }
}
