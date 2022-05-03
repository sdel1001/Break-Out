using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager Instance;

    public static GameManager GetGameInstance() { return Instance; }
    public SaveData saveGame = new SaveData();
    public string playerName;
    

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

    public void SaveGame()
    {
        saveGame.SaveGame();
    }

    public void LoadGame()
    {
        saveGame.LoadGame();
    }



  

   



}
