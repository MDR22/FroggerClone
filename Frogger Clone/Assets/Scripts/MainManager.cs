using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using System.IO;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        //Set high score and player name to compare against high scores

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNewGame()
    {
        //Update data to start the new game
        //playerAlias = aliasText.text;
        SceneManager.LoadScene(1);
        //Debug.Log(playerAlias);
    }

    //Creating save files
    [System.Serializable]

    class SaveData
    {
        //Add save data here - high score, player name, current score, etc.
    }

    public void SavePlayerData()
    {
        //SaveData data = new SaveData();
        //data.highScore = highScore;
        //data.highScoreAlias = highScoreAlias;

        //string json = JsonUtility.ToJson(data);

        //File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadPlayerData()
    {
        //string path = Application.persistentDataPath + "/savefile.json";
        //if (File.Exists(path))
        //{
        //    string json = File.ReadAllText(path);
        //    SaveData data = JsonUtility.FromJson<SaveData>(json);

        //    highScore = data.highScore;
        //    highScoreAlias = data.highScoreAlias;
        //}
    }

    private void OnApplicationQuit()
    {
        //SavePlayerData();
        //Debug.Log("Application has been exited. What is high score now? It is " + highScore + "and alias is " + highScoreAlias);
    }
}
