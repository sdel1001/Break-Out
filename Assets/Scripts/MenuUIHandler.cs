using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] GameObject playerName;
    [SerializeField] GameObject bestScore;

    TMP_InputField playerInput;
    TextMeshProUGUI bestScoreText;

    private void Start()
    {
        playerInput = playerName.GetComponent<TMP_InputField>();
        bestScoreText = bestScore.GetComponent<TextMeshProUGUI>();

        GameManager.GetGameInstance().LoadGame();
        bestScoreText.text = "Best Score : " + GameManager.GetGameInstance().saveGame.playerName + " : " + GameManager.GetGameInstance().saveGame.highScore;
    }


    public void StartNew()
    {
        SceneManager.LoadScene(1);
        GameManager.GetGameInstance().playerName = playerInput.text;
    }

    public void Exit()
    {
//MainManager.Instance.SaveColor();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

}
